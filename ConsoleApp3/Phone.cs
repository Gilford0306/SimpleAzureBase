using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Phone
    {
        public int id { get; set; }
        public string model { get; set; }

        public Phone()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}\t\t{id})\t{model}";
        }
    }
}
