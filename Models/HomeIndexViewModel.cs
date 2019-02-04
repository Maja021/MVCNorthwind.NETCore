using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFakture.Models
{
    public class HomeIndexViewModel
    {
        public int VisitorsCount;
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }

        
    }
}
