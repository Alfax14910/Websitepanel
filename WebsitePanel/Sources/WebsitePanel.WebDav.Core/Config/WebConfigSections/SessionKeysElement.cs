﻿using System.Configuration;

namespace WebsitePanel.WebDav.Core.Config.WebConfigSections
{
    public class SessionKeysElement : ConfigurationElement
    {
        private const string KeyKey = "key";
        private const string ValueKey = "value";

        public const string AccountInfoKey = "AccountInfoSessionKey";
        public const string AuthTicketKey = "AuthTicketKey";
        public const string WebDavManagerKey = "WebDavManagerSessionKey";
        public const string UserGroupsKey = "UserGroupsKey";
        public const string WebDavRootFolderPermissionsKey = "WebDavRootFolderPermissionsKey";
        public const string ResourseRenderCountKey = "ResourseRenderCountSessionKey";
        public const string ItemIdSessionKey = "ItemId";

        [ConfigurationProperty(KeyKey, IsKey = true, IsRequired = true)]
        public string Key
        {
            get { return (string) this[KeyKey]; }
            set { this[KeyKey] = value; }
        }

        [ConfigurationProperty(ValueKey, IsKey = true, IsRequired = true)]
        public string Value
        {
            get { return (string) this[ValueKey]; }
            set { this[ValueKey] = value; }
        }
    }
}