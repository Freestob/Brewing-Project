using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brewer.API.Models
{
    public class Grain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Form { get; set; }
        public double Color { get; set; }
        public double Potential { get; set; }
        public double CoarseFineDiff { get; set; }
        public double Moisture { get; set; }
        public double Protein { get; set; }
        public double Diasitic { get; set; }
        public double IBU { get; set; }
    }
}