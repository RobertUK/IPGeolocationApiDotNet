using System;

namespace IPGeolocation
{
    public class UserAgentParams
    {
        private String userAgent;

        public UserAgentParams()
        {
            userAgent = "";
        }

        public void SetUserAgent(String userAgent)
        {
            this.userAgent = Strings.NullToEmpty(userAgent);
        }

        public String GetUserAgent()
        {
            return userAgent;
        }

    }
}
