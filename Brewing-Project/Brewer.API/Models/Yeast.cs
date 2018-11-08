using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brewer.API.Models
{
    public class Yeast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YeastType { get; set; }
        public string Form { get; set; }
        public double Attenuation { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public string Flocculation { get; set; }
    }
}