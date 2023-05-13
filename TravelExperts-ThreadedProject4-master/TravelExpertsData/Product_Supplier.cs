using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Product_Supplier
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }     // nullable
        public int? SupplierId { get; set; }    // nullable
    }
}
