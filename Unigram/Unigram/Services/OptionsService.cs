﻿// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by TdParseOptions (http://github.com/UnigramDev/UnigramUtils/TdParseOptions)
// 
// 	Generated: 01/08/2019 11:13:35
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Td.Api;
using Unigram.ViewModels;

namespace Unigram.Services
{
    public interface IOptionsService : IHandle<UpdateOption>
    {
        IReadOnlyDictionary<string, OptionValue> Values { get; }

        T GetValue<T>(string key);
        bool TryGetValue<T>(string key, out T value);

        void Clear();



        /// <summary>
        /// TBD
        /// </summary>
        /// <value>expect_blocking</value>
        bool ExpectBlocking { get; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>enabled_proxy_id</value>
        int EnabledProxyId { get; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>storage_max_time_from_last_access</value>
        int StorageMaxTimeFromLastAccess { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>disable_pinned_message_notifications</value>
        bool DisablePinnedMessageNotifications { get; set; }

        /// <summary>
        /// If true, notifications about the user's contacts who have joined Telegram will be disabled
        /// </summary>
        /// <value>disable_contact_registered_notifications</value>
        bool DisableContactRegisteredNotifications { get; set; }

        /// <summary>
        /// If true, support for top chats and statistics collection is disabled.
        /// </summary>
        /// <value>disable_top_chats</value>
        bool DisableTopChats { get; set; }

        /// <summary>
        /// If true, prevents file thumbnails sent by the server along with messages from being saved on the disk
        /// </summary>
        /// <value>ignore_inline_thumbnails</value>
        bool IgnoreInlineThumbnails { get; set; }

        /// <summary>
        /// Path to a database for storing language pack strings, so that this database can be shared between different accounts. By default, language pack strings are stored only in memory.
        /// </summary>
        /// <value>language_pack_database_path</value>
        string LanguagePackDatabasePath { get; set; }

        /// <summary>
        /// Identifier of the currently used language pack from the current localization target
        /// </summary>
        /// <value>language_pack_id</value>
        string LanguagePackId { get; set; }

        /// <summary>
        /// Name for the current localization target (currently supported: "android", "android_x", "ios", "macos" and "tdesktop")
        /// </summary>
        /// <value>localization_target</value>
        string LocalizationTarget { get; set; }

        /// <summary>
        /// Online status of the current user
        /// </summary>
        /// <value>online</value>
        bool Online { get; set; }

        /// <summary>
        /// If true, IPv6 addresses will be preferred over IPv4 addresses
        /// </summary>
        /// <value>prefer_ipv6</value>
        bool PreferIpv6 { get; set; }

        /// <summary>
        /// If true, Perfect Forward Secrecy will be enabled for interaction with the Telegram servers for cloud chats
        /// </summary>
        /// <value>use_pfs</value>
        bool UsePfs { get; set; }

        /// <summary>
        /// If true, quick acknowledgement will be enabled for outgoing messages
        /// </summary>
        /// <value>use_quick_ack</value>
        bool UseQuickAck { get; set; }

        /// <summary>
        /// If true, the background storage optimizer will be enabled
        /// </summary>
        /// <value>use_storage_optimizer</value>
        bool UseStorageOptimizer { get; set; }

        /// <summary>
        /// Username of a bot which can be used in inline mode for animations search
        /// </summary>
        /// <value>animation_search_bot_username</value>
        string AnimationSearchBotUsername { get; }

        /// <summary>
        /// Point in time (Unix timestamp) when authorization was received
        /// </summary>
        /// <value>authorization_date</value>
        int AuthorizationDate { get; }

        /// <summary>
        /// Maximum number of members in a basic group
        /// </summary>
        /// <value>basic_group_size_max</value>
        int BasicGroupSizeMax { get; }

        /// <summary>
        /// Maximum time to wait for call connection creation to be passed to libtgvoip
        /// </summary>
        /// <value>call_connect_timeout_ms</value>
        int CallConnectTimeoutMs { get; }

        /// <summary>
        /// Maximum time to wait for call packet delivery to be passed to libtgvoip
        /// </summary>
        /// <value>call_packet_timeout_ms</value>
        int CallPacketTimeoutMs { get; }

        /// <summary>
        /// Maximum number of favorite stickers
        /// </summary>
        /// <value>favorite_stickers_limit</value>
        int FavoriteStickersLimit { get; }

        /// <summary>
        /// Maximum number of forwarded messages per one request
        /// </summary>
        /// <value>forwarded_message_count_max</value>
        int ForwardedMessageCountMax { get; }

        /// <summary>
        /// Maximum length of a message caption
        /// </summary>
        /// <value>message_caption_length_max</value>
        int MessageCaptionLengthMax { get; }

        /// <summary>
        /// Maximum length of a message text
        /// </summary>
        /// <value>message_text_length_max</value>
        int MessageTextLengthMax { get; }

        /// <summary>
        /// Identifier of the current user
        /// </summary>
        /// <value>my_id</value>
        int MyId { get; }

        /// <summary>
        /// Maximum number of pinned cloud chats. The same amount of secret chats can be pinned locally
        /// </summary>
        /// <value>pinned_chat_count_max</value>
        int PinnedChatCountMax { get; }

        /// <summary>
        /// Username of a bot which can be used in inline mode for photos search
        /// </summary>
        /// <value>photo_search_bot_username</value>
        string PhotoSearchBotUsername { get; }

        /// <summary>
        /// Identifier of the language pack, suggested for the user by the server
        /// </summary>
        /// <value>suggested_language_pack_id</value>
        string SuggestedLanguagePackId { get; }

        /// <summary>
        /// Maximum number of members in a supergroup
        /// </summary>
        /// <value>supergroup_size_max</value>
        int SupergroupSizeMax { get; }

        /// <summary>
        /// Current value of t.me URL, i.e. https://t.me/
        /// </summary>
        /// <value>t_me_url</value>
        string TMeUrl { get; }

        /// <summary>
        /// If true, the test environment is being used instead of the production environment
        /// </summary>
        /// <value>test_mode</value>
        bool TestMode { get; }

        /// <summary>
        /// Username of a bot which can be used in inline mode for venues search
        /// </summary>
        /// <value>venue_search_bot_username</value>
        string VenueSearchBotUsername { get; }

        /// <summary>
        /// TDLib version
        /// </summary>
        /// <value>version</value>
        string Version { get; }
    }

    public class OptionsService : IOptionsService
    {
        private readonly IProtoService _protoService;
        private readonly Dictionary<string, OptionValue> _values = new Dictionary<string, OptionValue>();

        public OptionsService(IProtoService protoService)
        {
            _protoService = protoService;
        }

        public void Handle(UpdateOption update)
        {
            switch (update.Name)
            {
                case "expect_blocking":
                    _expectBlocking = GetValue<bool>(update.Value);
                    break;
                case "enabled_proxy_id":
                    _enabledProxyId = GetValue<int>(update.Value);
                    break;
                case "storage_max_time_from_last_access":
                    _storageMaxTimeFromLastAccess = GetValue<int>(update.Value);
                    break;
                case "disable_pinned_message_notifications":
                    _disablePinnedMessageNotifications = GetValue<bool>(update.Value);
                    break;
                case "disable_contact_registered_notifications":
                    _disableContactRegisteredNotifications = GetValue<bool>(update.Value);
                    break;
                case "disable_top_chats":
                    _disableTopChats = GetValue<bool>(update.Value);
                    break;
                case "ignore_inline_thumbnails":
                    _ignoreInlineThumbnails = GetValue<bool>(update.Value);
                    break;
                case "language_pack_database_path":
                    _languagePackDatabasePath = GetValue<string>(update.Value);
                    break;
                case "language_pack_id":
                    _languagePackId = GetValue<string>(update.Value);
                    break;
                case "localization_target":
                    _localizationTarget = GetValue<string>(update.Value);
                    break;
                case "online":
                    _online = GetValue<bool>(update.Value);
                    break;
                case "prefer_ipv6":
                    _preferIpv6 = GetValue<bool>(update.Value);
                    break;
                case "use_pfs":
                    _usePfs = GetValue<bool>(update.Value);
                    break;
                case "use_quick_ack":
                    _useQuickAck = GetValue<bool>(update.Value);
                    break;
                case "use_storage_optimizer":
                    _useStorageOptimizer = GetValue<bool>(update.Value);
                    break;
                case "animation_search_bot_username":
                    _animationSearchBotUsername = GetValue<string>(update.Value);
                    break;
                case "authorization_date":
                    _authorizationDate = GetValue<int>(update.Value);
                    break;
                case "basic_group_size_max":
                    _basicGroupSizeMax = GetValue<int>(update.Value);
                    break;
                case "call_connect_timeout_ms":
                    _callConnectTimeoutMs = GetValue<int>(update.Value);
                    break;
                case "call_packet_timeout_ms":
                    _callPacketTimeoutMs = GetValue<int>(update.Value);
                    break;
                case "favorite_stickers_limit":
                    _favoriteStickersLimit = GetValue<int>(update.Value);
                    break;
                case "forwarded_message_count_max":
                    _forwardedMessageCountMax = GetValue<int>(update.Value);
                    break;
                case "message_caption_length_max":
                    _messageCaptionLengthMax = GetValue<int>(update.Value);
                    break;
                case "message_text_length_max":
                    _messageTextLengthMax = GetValue<int>(update.Value);
                    break;
                case "my_id":
                    _myId = GetValue<int>(update.Value);
                    break;
                case "pinned_chat_count_max":
                    _pinnedChatCountMax = GetValue<int>(update.Value);
                    break;
                case "photo_search_bot_username":
                    _photoSearchBotUsername = GetValue<string>(update.Value);
                    break;
                case "suggested_language_pack_id":
                    _suggestedLanguagePackId = GetValue<string>(update.Value);
                    break;
                case "supergroup_size_max":
                    _supergroupSizeMax = GetValue<int>(update.Value);
                    break;
                case "t_me_url":
                    _tMeUrl = GetValue<string>(update.Value);
                    break;
                case "test_mode":
                    _testMode = GetValue<bool>(update.Value);
                    break;
                case "venue_search_bot_username":
                    _venueSearchBotUsername = GetValue<string>(update.Value);
                    break;
                case "version":
                    _version = GetValue<string>(update.Value);
                    break;
                default:
                    _values[update.Name] = update.Value;
                    break;
            }
        }

        private T GetValue<T>(OptionValue option)
        {
            if (option is OptionValueBoolean valueBoolean && typeof(T) == typeof(bool))
            {
                return (T)(object)valueBoolean.Value;
            }
            else if (option is OptionValueInteger valueInteger && typeof(T) == typeof(int))
            {
                return (T)(object)valueInteger.Value;
            }
            else if (option is OptionValueString valueString && typeof(T) == typeof(string))
            {
                return (T)(object)valueString.Value;
            }
            else if (option is OptionValueEmpty)
            {
                return default(T);
            }

            Logs.Log.Write($"OptionsService, mismatching type, {typeof(T)} requested, {option.GetType()} received");
            return default(T);
        }

        private bool TryGetValue<T>(OptionValue option, out T value)
        {
            if (option is OptionValueBoolean valueBoolean && typeof(T) == typeof(bool))
            {
                value = (T)(object)valueBoolean.Value;
                return true;
            }
            else if (option is OptionValueInteger valueInteger && typeof(T) == typeof(int))
            {
                value = (T)(object)valueInteger.Value;
                return true;
            }
            else if (option is OptionValueString valueString && typeof(T) == typeof(string))
            {
                value = (T)(object)valueString.Value;
                return true;
            }
            else if (option is OptionValueEmpty)
            {
                value = default(T);
                return false;
            }

            Logs.Log.Write($"OptionsService, mismatching type, {typeof(T)} requested, {option.GetType()} received");
            value = default(T);
            return false;
        }



        public IReadOnlyDictionary<string, OptionValue> Values => _values;

        public T GetValue<T>(string key)
        {
            if (_values.TryGetValue(key, out OptionValue option))
            {
                return GetValue<T>(option);
            }

            return default(T);
        }

        public bool TryGetValue<T>(string key, out T value)
        {
            if (_values.TryGetValue(key, out OptionValue option))
            {
                return TryGetValue<T>(option, out value);
            }

            value = default(T);
            return false;
        }

        public void Clear()
        {
            _values.Clear();
        }

        private bool _expectBlocking;
        public bool ExpectBlocking
        {
            get { return _expectBlocking; }
        }

        private int _enabledProxyId;
        public int EnabledProxyId
        {
            get { return _enabledProxyId; }
        }

        private int _storageMaxTimeFromLastAccess;
        public int StorageMaxTimeFromLastAccess
        {
            get { return _storageMaxTimeFromLastAccess; }
            set
            {
                _storageMaxTimeFromLastAccess = value;
                _protoService.Send(new SetOption("storage_max_time_from_last_access", new OptionValueInteger(value)));
            }
        }

        private bool _disablePinnedMessageNotifications;
        public bool DisablePinnedMessageNotifications
        {
            get { return _disablePinnedMessageNotifications; }
            set
            {
                _disablePinnedMessageNotifications = value;
                _protoService.Send(new SetOption("disable_pinned_message_notifications", new OptionValueBoolean(value)));
            }
        }

        private bool _disableContactRegisteredNotifications;
        public bool DisableContactRegisteredNotifications
        {
            get { return _disableContactRegisteredNotifications; }
            set
            {
                _disableContactRegisteredNotifications = value;
                _protoService.Send(new SetOption("disable_contact_registered_notifications", new OptionValueBoolean(value)));
            }
        }

        private bool _disableTopChats;
        public bool DisableTopChats
        {
            get { return _disableTopChats; }
            set
            {
                _disableTopChats = value;
                _protoService.Send(new SetOption("disable_top_chats", new OptionValueBoolean(value)));
            }
        }

        private bool _ignoreInlineThumbnails;
        public bool IgnoreInlineThumbnails
        {
            get { return _ignoreInlineThumbnails; }
            set
            {
                _ignoreInlineThumbnails = value;
                _protoService.Send(new SetOption("ignore_inline_thumbnails", new OptionValueBoolean(value)));
            }
        }

        private string _languagePackDatabasePath;
        public string LanguagePackDatabasePath
        {
            get { return _languagePackDatabasePath; }
            set
            {
                _languagePackDatabasePath = value;
                _protoService.Send(new SetOption("language_pack_database_path", new OptionValueString(value)));
            }
        }

        private string _languagePackId;
        public string LanguagePackId
        {
            get { return _languagePackId; }
            set
            {
                _languagePackId = value;
                _protoService.Send(new SetOption("language_pack_id", new OptionValueString(value)));
            }
        }

        private string _localizationTarget;
        public string LocalizationTarget
        {
            get { return _localizationTarget; }
            set
            {
                _localizationTarget = value;
                _protoService.Send(new SetOption("localization_target", new OptionValueString(value)));
            }
        }

        private bool _online;
        public bool Online
        {
            get { return _online; }
            set
            {
                _online = value;
                _protoService.Send(new SetOption("online", new OptionValueBoolean(value)));
            }
        }

        private bool _preferIpv6;
        public bool PreferIpv6
        {
            get { return _preferIpv6; }
            set
            {
                _preferIpv6 = value;
                _protoService.Send(new SetOption("prefer_ipv6", new OptionValueBoolean(value)));
            }
        }

        private bool _usePfs;
        public bool UsePfs
        {
            get { return _usePfs; }
            set
            {
                _usePfs = value;
                _protoService.Send(new SetOption("use_pfs", new OptionValueBoolean(value)));
            }
        }

        private bool _useQuickAck;
        public bool UseQuickAck
        {
            get { return _useQuickAck; }
            set
            {
                _useQuickAck = value;
                _protoService.Send(new SetOption("use_quick_ack", new OptionValueBoolean(value)));
            }
        }

        private bool _useStorageOptimizer;
        public bool UseStorageOptimizer
        {
            get { return _useStorageOptimizer; }
            set
            {
                _useStorageOptimizer = value;
                _protoService.Send(new SetOption("use_storage_optimizer", new OptionValueBoolean(value)));
            }
        }

        private string _animationSearchBotUsername;
        public string AnimationSearchBotUsername
        {
            get { return _animationSearchBotUsername; }
        }

        private int _authorizationDate;
        public int AuthorizationDate
        {
            get { return _authorizationDate; }
        }

        private int _basicGroupSizeMax;
        public int BasicGroupSizeMax
        {
            get { return _basicGroupSizeMax; }
        }

        private int _callConnectTimeoutMs;
        public int CallConnectTimeoutMs
        {
            get { return _callConnectTimeoutMs; }
        }

        private int _callPacketTimeoutMs;
        public int CallPacketTimeoutMs
        {
            get { return _callPacketTimeoutMs; }
        }

        private int _favoriteStickersLimit;
        public int FavoriteStickersLimit
        {
            get { return _favoriteStickersLimit; }
        }

        private int _forwardedMessageCountMax;
        public int ForwardedMessageCountMax
        {
            get { return _forwardedMessageCountMax; }
        }

        private int _messageCaptionLengthMax;
        public int MessageCaptionLengthMax
        {
            get { return _messageCaptionLengthMax; }
        }

        private int _messageTextLengthMax;
        public int MessageTextLengthMax
        {
            get { return _messageTextLengthMax; }
        }

        private int _myId;
        public int MyId
        {
            get { return _myId; }
        }

        private int _pinnedChatCountMax;
        public int PinnedChatCountMax
        {
            get { return _pinnedChatCountMax; }
        }

        private string _photoSearchBotUsername;
        public string PhotoSearchBotUsername
        {
            get { return _photoSearchBotUsername; }
        }

        private string _suggestedLanguagePackId;
        public string SuggestedLanguagePackId
        {
            get { return _suggestedLanguagePackId; }
        }

        private int _supergroupSizeMax;
        public int SupergroupSizeMax
        {
            get { return _supergroupSizeMax; }
        }

        private string _tMeUrl;
        public string TMeUrl
        {
            get { return _tMeUrl; }
        }

        private bool _testMode;
        public bool TestMode
        {
            get { return _testMode; }
        }

        private string _venueSearchBotUsername;
        public string VenueSearchBotUsername
        {
            get { return _venueSearchBotUsername; }
        }

        private string _version;
        public string Version
        {
            get { return _version; }
        }
    }
}