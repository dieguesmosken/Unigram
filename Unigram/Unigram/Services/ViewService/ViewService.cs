﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Unigram.Navigation;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using static Unigram.Services.Logging.LoggingService;

namespace Unigram.Services.ViewService
{
    public sealed class ViewService : IViewService
    {
        internal static void OnWindowCreated()
        {
            var view = CoreApplication.GetCurrentView();
            if (!view.IsMain && !view.IsHosted)
            {
                var control = ViewLifetimeControl.GetForCurrentView();
                //This one time it should be made manually, as after Consolidate event fires the inner reference number should become zero
                control.StartViewInUse();
                //This is necessary to not make control.StartViewInUse()/control.StopViewInUse() manually on each and every async call. Facade will do it for you
                SynchronizationContext.SetSynchronizationContext(new SecondaryViewSynchronizationContextDecorator(control,
                    SynchronizationContext.Current));
            }
        }

        public async Task<ViewLifetimeControl> OpenAsync(Func<UIElement> content, object parameter, double width, double height)
        {
            if (_windows.TryGetValue(parameter, out DispatcherWrapper value))
            {
                var newControl = await value.Dispatch(async () =>
                {
                    var control = ViewLifetimeControl.GetForCurrentView();
                    var newAppView = ApplicationView.GetForCurrentView();

                    var preferences = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
                    preferences.CustomSize = new Size(width, height);

                    await ApplicationViewSwitcher
                    .TryShowAsViewModeAsync(newAppView.Id, ApplicationViewMode.CompactOverlay, preferences);

                    return control;
                }).ConfigureAwait(false);
                return newControl;
            }
            else
            {
                var newView = CoreApplication.CreateNewView();
                var dispatcher = new DispatcherWrapper(newView.Dispatcher);
                _windows[parameter] = dispatcher;

                var bounds = Window.Current.Bounds;

                var newControl = await dispatcher.Dispatch(async () =>
                {
                    var newWindow = Window.Current;
                    newWindow.Closed += (s, args) =>
                    {
                        _windows.TryRemove(parameter, out DispatcherWrapper ciccio);
                    };
                    newWindow.CoreWindow.Closed += (s, args) =>
                    {
                        _windows.TryRemove(parameter, out DispatcherWrapper ciccio);
                    };

                    var newAppView = ApplicationView.GetForCurrentView();
                    newAppView.Consolidated += (s, args) =>
                    {
                        _windows.TryRemove(parameter, out DispatcherWrapper ciccio);
                        newWindow.Close();
                    };

                    var control = ViewLifetimeControl.GetForCurrentView();
                    control.Released += (s, args) =>
                    {
                        _windows.TryRemove(parameter, out DispatcherWrapper ciccio);
                        newWindow.Close();
                    };

                    newWindow.Content = content();
                    newWindow.Activate();

                    var preferences = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
                    preferences.CustomSize = new Size(width, height);

                    await ApplicationViewSwitcher
                    .TryShowAsViewModeAsync(newAppView.Id, ApplicationViewMode.CompactOverlay, preferences);

                    return control;
                }).ConfigureAwait(false);
                return newControl;
            }
        }

        public async Task<ViewLifetimeControl> OpenAsync(Type page, object parameter = null, string title = null,
            ViewSizePreference size = ViewSizePreference.UseHalf, int session = 0, string id = "0")
        {
            WriteLine($"Page: {page}, Parameter: {parameter}, Title: {title}, Size: {size}");

            var currentView = ApplicationView.GetForCurrentView();
            title = title ?? currentView.Title;









            if (parameter != null && _windows.TryGetValue(parameter, out DispatcherWrapper value))
            {
                var newControl = await value.Dispatch(async () =>
                {
                    var control = ViewLifetimeControl.GetForCurrentView();
                    var newAppView = ApplicationView.GetForCurrentView();

                    var preferences = ViewModePreferences.CreateDefault(ApplicationViewMode.Default);
                    preferences.CustomSize = new Windows.Foundation.Size(360, 640);

                    await ApplicationViewSwitcher
                        .SwitchAsync(newAppView.Id, currentView.Id, ApplicationViewSwitchingOptions.Default);

                    return control;
                }).ConfigureAwait(false);
                return newControl;
            }
            else
            {
                var newView = CoreApplication.CreateNewView();
                var dispatcher = new DispatcherWrapper(newView.Dispatcher);

                if (parameter != null)
                {
                    _windows[parameter] = dispatcher;
                }

                var bounds = Window.Current.Bounds;

                var newControl = await dispatcher.Dispatch(async () =>
                {
                    var newWindow = Window.Current;
                    var newAppView = ApplicationView.GetForCurrentView();
                    newAppView.Title = title;

                    var control = ViewLifetimeControl.GetForCurrentView();
                    control.Released += (s, args) =>
                    {
                        if (parameter != null)
                        {
                            _windows.TryRemove(parameter, out DispatcherWrapper ciccio);
                        }

                        newWindow.Close();
                    };

                    var nav = BootStrapper.Current.NavigationServiceFactory(BootStrapper.BackButton.Ignore, BootStrapper.ExistingContent.Exclude, session, id, false);
                    control.NavigationService = nav;
                    nav.Navigate(page, parameter);
                    newWindow.Content = BootStrapper.Current.CreateRootElement(nav);
                    newWindow.Activate();

                    await ApplicationViewSwitcher
                        .TryShowAsStandaloneAsync(newAppView.Id, ViewSizePreference.Default, currentView.Id, size);
                    //newAppView.TryResizeView(new Windows.Foundation.Size(360, bounds.Height));
                    newAppView.TryResizeView(new Windows.Foundation.Size(360, 640));

                    return control;
                }).ConfigureAwait(false);
                return newControl;
            }
        }

        private readonly ConcurrentDictionary<object, DispatcherWrapper> _windows = new ConcurrentDictionary<object, DispatcherWrapper>();
    }
}
