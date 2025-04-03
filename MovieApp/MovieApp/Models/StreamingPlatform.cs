using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class StreamingPlatform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri ImagePath {  get; set; } 
    }
}
