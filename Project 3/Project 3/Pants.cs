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

        //int 5 = 30;
    }
    class Pants
    {
        public void PantsDeptment()
        {
            int PantsChoice;



            Console.WriteLine("What style of pants would you like? \n 1. Jeans \n 2. DressPants \n 3. Corduroy \n 4. Linen \n 5. Capri's \n");

            string pants = Console.ReadLine();

            int.TryParse(pants, out PantsChoice);

            switch ((PantsStyle)PantsChoice)
            {
                case PantsStyle.Jeans:
                    Console.WriteLine("We are having a 30% off sale on jeans today only!!");
                    break;

                case PantsStyle.DressPants:
                    Console.WriteLine("What style of Dress pants would you like to see? We offer 1. Linen, 2.Rayon,  and 3.Cotton ");
                    ////if
                    //{   

                    //}
                    break;

                case PantsStyle.Cordoroy:
                    Console.WriteLine("Our Cordoroy's are made of 100% cotton and come with an fleece lining ");
                    break;

                case PantsStyle.Linen:
                    Console.WriteLine("Our Linen pants are a nice addition to any wardrobe and are extremely versatile");
                    break;

                case PantsStyle.SlimFit:
                    Console.WriteLine("Our Slim fit pants are made with a blend of cotton and spandex");
                    show();
                    break;

                case PantsStyle.Capris:
                    Console.WriteLine("Our Capri pants come in a wide array of colors and materials");
                    break;

                default:
                    Console.WriteLine("Thank you for shopping with us today. Please come again");
                    break;




            }
        }
            public static void show()
        {
            
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
        
    




    }
}
