using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class PackageHC
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; } // nullable
        public DateTime? PkgEndDate { get; set; }   // nullable
        public string PkgDesc { get; set; }        // reference types contain null value
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }   // nullable
    }
}
