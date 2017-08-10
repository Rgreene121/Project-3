using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    enum PantsStyle
    {
        Jeans = 1,
        DressPants =2,
        Cordoroy = 3,
        Linen = 4,
        Capris = 5,
        Bootcut = 6,
        SlimFit = 7

        //int 5 = 30,
    }
    class Pants

    {
        static void Main(string[] args)
        {
            int PantsChoice;


            Console.WriteLine("Welcome to the Pants department, What style of pants would you like? \n 1. Jeans \n 2. DressPants \n 3. Corduroy \n 4. Linen \n 5. Capri's \n");

            string pants = Console.ReadLine();

            int.TryParse(pants, out PantsChoice);

            switch ((PantsStyle)PantsChoice)
            {
                case PantsStyle.Jeans:
                    Console.WriteLine("");
                    break;

                case PantsStyle.DressPants:
                    Console.WriteLine(" ");
                    break;

                case PantsStyle.Cordoroy:
                    Console.WriteLine(" ");
                    break;

                case PantsStyle.Linen:
                    Console.WriteLine("");
                    break;

                case PantsStyle.SlimFit:
                    Console.WriteLine("");
                    break;

                case PantsStyle.Capris:
                    Console.WriteLine("");
                    break;




            }
        }
    




    }
}
