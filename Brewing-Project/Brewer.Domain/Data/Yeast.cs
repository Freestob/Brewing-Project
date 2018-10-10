using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Domain.Data
{
    public class Yeast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lab { get; set; }
        public string ProductId { get; set; }
        public string Type { get; set; }
        public string Form { get; set; }
        public double Inventory { get; set; }
        public double Price { get; set; }
    }
}
