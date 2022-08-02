using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distribution_Warehouse.Utils;

namespace Distribution_Warehouse.Products
{
    internal class Fruits : IProduct
    {
        public string Name { get; set; }
        public MeasurableUnit Unit { get; set; }
        public float Wpu { get; set; } //weight per unit
        public string PricePerUnit { get; set; }
        public string NutritionalQuality { get; set; }

    }
}
