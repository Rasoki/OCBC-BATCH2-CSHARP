using System.Collections.Generic;

namespace PaymentWithJWT2.Configuration
{
    public class AuthResult
    {
        public string Token { get; set; }
        public bool success { get; set; }
        public List<string> Errors { get; set; }
    }
}