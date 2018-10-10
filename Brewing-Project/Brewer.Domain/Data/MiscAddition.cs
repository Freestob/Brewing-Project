using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Domain.Data
{
    public class MiscAddition
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string UseFor { get; set; }
        public double Time { get; set; }
        public double Inventory { get; set; }
        public double Price { get; set; }
    }
}
