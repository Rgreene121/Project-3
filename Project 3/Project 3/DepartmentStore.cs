using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{

    Enum StyleOptions
    {
        Shirts = 1,
        Shoes,
        Pants,
        Hats
    }

    class DepartmentStore
    {//base class

        int stylePick;

        public void StyleChoice()
        {
            Console.WriteLine($"Welcome to RAD, which department would you like to shop from 1.Shirts or 2.Shoes or 3.Pants or 4.Hats?");

            string style = Console.ReadLine();

            int.TryParse(stylePick, out StyleChoice);

            switch ((stylePick)StyleChoice)

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
       



      



