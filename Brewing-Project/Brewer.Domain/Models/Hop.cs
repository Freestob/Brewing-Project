using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Domain.Models
{
    public class Hop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Purpose { get; set; }
        public string Form { get; set; }
        public double Alpha { get; set; }
        public double Beta { get; set; }
    }
}
