using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Domain.Data
{
    public class Hop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public double Alpha { get; set; }
        public string Type { get; set; }
        public double Inventory { get; set; }
        public double Price { get; set; }
    }
}
