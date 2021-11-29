using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_WebAPI.Models
{
    public class MovieItem
    {
        private Models.MovieContext context;

        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }
        public string date { get; set; }
    }
}
