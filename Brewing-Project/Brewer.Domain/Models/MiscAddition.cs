using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Domain.Models
{
    public class MiscAddition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UseFor { get; set; }
        public double Amount { get; set; }
        public double BatchSize { get; set; }
        public string AddTo { get; set; }
        public double Time { get; set; }
    }
}
