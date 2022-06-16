using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorlibBack.Models
{
    public class Dinner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
    }
}
