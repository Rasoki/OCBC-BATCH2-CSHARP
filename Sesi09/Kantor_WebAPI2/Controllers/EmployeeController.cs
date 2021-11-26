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

        public  EmployeeController(EmployeeContext context)
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
    }
}
