using ColorlibBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorlibBack.ViewModels
{
    public class HomeVM
    {
        public List<Breakfast> Breakfasts { get; set; }
        public List<Brunch> Brunches { get; set; }
        public List<Dinner> Dinners { get; set; }
    }
}
