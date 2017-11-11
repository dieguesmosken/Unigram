//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by ResW File Code Generator (http://bit.ly/reswcodegen)
// 	ResW File Code Generator was written by Christian Resma Helle
// 	and is under GNU General Public License version 2 (GPLv2)
// 
// 	This code contains a helper class exposing property representations
// 	of the string resources defined in the specified .ResW file
// 
// 	Generated: 11/11/2017 21:16:10
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
namespace Unigram.Strings
{
    using Windows.ApplicationModel.Resources;
    
    
    public sealed partial class DialogResources
    {
        
        private static ResourceLoader resourceLoader;
        
        static DialogResources()
        {
            string executingAssemblyName;
            executingAssemblyName = Windows.UI.Xaml.Application.Current.GetType().AssemblyQualifiedName;
            string[] executingAssemblySplit;
            executingAssemblySplit = executingAssemblyName.Split(',');
            executingAssemblyName = executingAssemblySplit[1];
            string currentAssemblyName;
            currentAssemblyName = typeof(DialogResources).AssemblyQualifiedName;
            string[] currentAssemblySplit;
            currentAssemblySplit = currentAssemblyName.Split(',');
            currentAssemblyName = currentAssemblySplit[1];
            if (executingAssemblyName.Equals(currentAssemblyName))
            {
                resourceLoader = ResourceLoader.GetForCurrentView("DialogResources");
            }
            else
            {
                resourceLoader = ResourceLoader.GetForCurrentView(currentAssemblyName + "/DialogResources");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Cancel"
        /// </summary>
        public static string Cancel
        {
            get
            {
                return resourceLoader.GetString("Cancel");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Clear history"
        /// </summary>
        public static string DialogClearHistory
        {
            get
            {
                return resourceLoader.GetString("DialogClearHistory");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete conversation"
        /// </summary>
        public static string DialogDelete
        {
            get
            {
                return resourceLoader.GetString("DialogDelete");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete and exit"
        /// </summary>
        public static string DialogDeleteAndExit
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteAndExit");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete and stop"
        /// </summary>
        public static string DialogDeleteAndStop
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteAndStop");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete channel"
        /// </summary>
        public static string DialogDeleteChannel
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteChannel");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete group"
        /// </summary>
        public static string DialogDeleteGroup
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteGroup");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Leave channel"
        /// </summary>
        public static string DialogLeaveChannel
        {
            get
            {
                return resourceLoader.GetString("DialogLeaveChannel");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Leave group"
        /// </summary>
        public static string DialogLeaveGroup
        {
            get
            {
                return resourceLoader.GetString("DialogLeaveGroup");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Disable notifications"
        /// </summary>
        public static string DialogNotificationsDisable
        {
            get
            {
                return resourceLoader.GetString("DialogNotificationsDisable");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Enable notifications"
        /// </summary>
        public static string DialogNotificationsEnable
        {
            get
            {
                return resourceLoader.GetString("DialogNotificationsEnable");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Pin to top"
        /// </summary>
        public static string DialogPin
        {
            get
            {
                return resourceLoader.GetString("DialogPin");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Unpin from top"
        /// </summary>
        public static string DialogUnpin
        {
            get
            {
                return resourceLoader.GetString("DialogUnpin");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "More info"
        /// </summary>
        public static string MoreInfo
        {
            get
            {
                return resourceLoader.GetString("MoreInfo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "No"
        /// </summary>
        public static string No
        {
            get
            {
                return resourceLoader.GetString("No");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "OK"
        /// </summary>
        public static string OK
        {
            get
            {
                return resourceLoader.GetString("OK");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Yes"
        /// </summary>
        public static string Yes
        {
            get
            {
                return resourceLoader.GetString("Yes");
            }
        }
    }
}
