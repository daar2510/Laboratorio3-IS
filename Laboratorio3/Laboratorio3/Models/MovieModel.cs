using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio3.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Genre { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
}
