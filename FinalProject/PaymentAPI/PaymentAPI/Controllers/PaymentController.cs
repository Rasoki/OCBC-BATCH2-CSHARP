using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PaymentAPI.Models;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private PaymentContext _context;

        public PaymentController(PaymentContext context)
        {
            this._context = context;
        }

        // GET: api/User
        [HttpGet(Name = "GetAll")]
        public ActionResult<IEnumerable<PaymentItem>> GetPaymentItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentContext)) as PaymentContext;
            //return new string[]
            return _context.GetAllPayment();
        }

        // Get : api/user/{id}
        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<IEnumerable<PaymentItem>> GetPaymentItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentContext)) as PaymentContext;
            return _context.GetPayment(id);
        }

        // Post : api/user
        [HttpPost(Name = "PostUser")]
        public string CreatePayment(PaymentItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentContext)) as PaymentContext;
            return _context.CreatePayment(item);
        }

        // Put : api/user/{id}
        [HttpPut("{id}", Name = "UpdateUser")]
        public string UpdatePayment(PaymentItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentContext)) as PaymentContext;
            return _context.UpdatePayment(item);
        }

        // Delete : api/user/{id}
        [HttpDelete("{id}", Name = "DeleteUser")]
        public string DeletePayment(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(PaymentContext)) as PaymentContext;
            return _context.DeletePayment(id);
        }
    }
}


