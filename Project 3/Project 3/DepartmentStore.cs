using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class DepartmentStore
    {
            public string Shirts;
            public string Shoes;
            public string Pants;
            public string Hats;

        public void Dept(DepartmentStore)
        {
            Console.WriteLine($"Welcome to RAD, which department would you like to shop from {Shirts} or{Shoes} or {Pants} or {Hats}?");
        }
    }
}
