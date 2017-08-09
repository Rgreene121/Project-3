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

        public void PrintOptions()
        {
            Console.WriteLine($"Welcome to RAD, which department would you like to shop from {Shirts} or{Shoes} or {Pants} or {Hats}?");

        }
    }
    class Shirts
    {

        public void ShirtsO()
        {
            Console.WriteLine($"1.Flower Print, 2.Animal Print, 3.Crop Style, 4.Button Down 5.Baby Doll Style 6.Hooded Top");

        }
    }
    class Shoes
    {
        public void ShoesO()
        {
            
           Console.WriteLine($"1.Tennis Shoes 2.Slip On 3.Flip Flops 4.Heels 5.Flats 6.Mules");


        }
    }



}
       



      



