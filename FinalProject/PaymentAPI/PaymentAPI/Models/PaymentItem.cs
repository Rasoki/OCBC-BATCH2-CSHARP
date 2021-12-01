using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models;

namespace PaymentAPI.Models
{
    public class PaymentItem
    {
        private Models.PaymentContext context;

        public int id { get; set; }
        public string cardName { get; set; }
        public string cardNumber { get; set; }
        public string expirationDate { get; set; }
        public string securityCode { get; set; }

    }
}
