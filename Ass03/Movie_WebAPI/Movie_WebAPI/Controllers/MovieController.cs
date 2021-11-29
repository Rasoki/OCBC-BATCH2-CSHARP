using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Movie_WebAPI.Models;

namespace Movie_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        //GET: api/User
        [HttpGet(Name = "GetAll")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            //return new string[]
            return _context.GetAllMovie();
        }

        // Get : api/user/{id}
        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        // Post : api/user
        [HttpPost(Name = "PostUser")]
        public string CreateMovie(MovieItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.CreateMovie(item);
        }

        // Put : api/user/{id}
        [HttpPut(Name = "UpdateUser")]
        public string UpdateEmployee(MovieItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.UpdateMovie(item);
        }

        // Delete : api/user/{id}
        [HttpDelete("{id}", Name = "DeleteUser")]
        public string DeleteMovie(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(id);
        }
    }
}
