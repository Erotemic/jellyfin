﻿
namespace MediaBrowser.Model.Connect
{
    public class ConnectAuthorizationRequest
    {
        public string SendingUserId { get; set; }
        public string ConnectUserName { get; set; }
        public string[] ExcludedLibraries { get; set; }
        public bool EnableLiveTv { get; set; }
        public string[] EnabledChannels { get; set; }

        public ConnectAuthorizationRequest()
        {
            ExcludedLibraries = new string[] { };
            EnabledChannels = new string[] { };
        }
    }
}
