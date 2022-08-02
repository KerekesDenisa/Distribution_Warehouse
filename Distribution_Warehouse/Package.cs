using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Warehouse
{
    internal class Package 
    {
        public int Quantity { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public IProduct Product { get; set; } //dupa categorie
    }
}
