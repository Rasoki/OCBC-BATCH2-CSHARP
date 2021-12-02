using System.Collections.Generic;

namespace PaymentAPI2.Configuration
{
    public class AuthResult
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool success { get; set; }
        public List<string> Errors { get; set; }
    }
}