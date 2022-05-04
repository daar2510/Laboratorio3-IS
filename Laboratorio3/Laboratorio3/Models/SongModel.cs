using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio3.Models
{
    public class SongModel
    {
        public String Name { get; set; }
        public String Genre { get; set; }
        public String Album { get; set; }
        public DateTime ReleasedDate { get; set; }
        public String Lyrics { get; set; }
    }
}
