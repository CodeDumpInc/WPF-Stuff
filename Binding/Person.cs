using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }

        ~Person()
        {
            Console.WriteLine(FirstName + " " + this.LastName);
        }
    }
}
