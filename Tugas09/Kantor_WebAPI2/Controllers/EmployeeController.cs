using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI2.Model;

namespace Kantor_WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        //GET: api/User
        [HttpGet(Name = "GetAll")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            //return new string[]
            return _context.GetAllEmployee();
        }

        // Get : api/user/{id}
        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);

        }

        // Post : api/user
        [HttpPost(Name = "PostUser")]
        public string CreateEmployee(EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.CreateEmployee(item);
        }

        // Put : api/user/{id}
        [HttpPut(Name = "UpdateUser")]
        public string UpdateEmployee(EmployeeItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateEmployee(item);
        }

        // Delete : api/user/{id}
        [HttpDelete("{id}", Name = "DeleteUser")]
        public string DeleteEmployee(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DeleteEmployee(id);
        }


    }
}
