using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Person
    {
        public string Name { get; set; }
        public List<string> Interests { get; set; }

        public Person(string name, params string[] interests)
        {
            Name = name;
            Interests = new List<string>(interests);
        }

        
    }
}


