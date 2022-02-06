using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220131_MVOP
{
    public class Person
    {
        string name { get; set; }
        string surname { get; set; }
        int birthyear { get; set; }
    }
    public class Worker : Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int birthyear { get; set; }
        public string education { get; set; }
        public string position { get; set; }
        public double wage { get; set; }
    }
}
