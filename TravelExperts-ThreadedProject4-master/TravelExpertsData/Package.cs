using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Package
    {
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public DateTime PackageStartDate { get; set; }
        public DateTime PackageEndDate { get; set; }
        public string PackageDescription { get; set; }
        public double PackageBasePrice { get; set; }
        public double PackageCommission { get; set; }

    }
}
