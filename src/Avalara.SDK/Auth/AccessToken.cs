using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Auth
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime ExpiryTime { get; set; }

        public AccessToken(string token, DateTime expiryTime)
        {
            Token = token;
            ExpiryTime = expiryTime;
        }
    }
}
