using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{

    //Enum StyleOptions
    //{
    //    Shirts = 1;
    //    Shoes;
    //    Pants;
    //    Hats;
    //}

    class DepartmentStore
    {//base class
       

        //public void PrintOptions()
        //{
        //    Console.WriteLine($"Welcome to RAD, which department would you like to shop from {Shirts} or{Shoes} or {Pants} or {Hats}?");

        //}
    }
    class Shirts
    {
        enum ShirtStyle
        {
            FlowerPrint = 1,
            AnimalPrint,
            CropStyle,
            ButtonDown,
            BabyDollStyle,
            HoodedTop

                                      
        }

        public void ShirtO()
        {
            int ShirtChoice;

            Console.WriteLine($"Please select a style 1.Flower Print, 2.Animal Print, 3.Crop Style, 4.Button Down 5.Baby Doll Style 6.Hooded Top");

            string Shirts = Console.ReadLine();

            int.TryParse(Shirts, out ShirtChoice);

            switch ((ShirtStyle)ShirtChoice)
            {
                case ShirtStyle.FlowerPrint:
                     Console.WriteLine("You have chosen our Spring collection");
                    break;

                case ShirtStyle.AnimalPrint:
                    Console.WriteLine("You have chosen our Exotic collection");
                    break;

                case ShirtStyle.CropStyle:
                    Console.WriteLine("You have chosen our Summer collection");
                    break;

                case ShirtStyle.ButtonDown:
                    Console.WriteLine("You have chosen our Conservative collection");
                    break;

                case ShirtStyle.BabyDollStyle:
                    Console.WriteLine("You have chosen a $ALE ITEM");
                    break;

                case ShirtStyle.HoodedTop:
                    Console.WriteLine("You have chosen our Fall collection");
                    break;

            }
            Console.WriteLine("");





        }
    }
    class Shoes
    {
        enum ShoeStyle
        {
            TennisShoes = 1,
            SlipOn,
            FlipFlops,
            Heels,
            Flats,
            Mules
        




        }
        public void ShoesO()
        {
            int ShoeChoice;

           Console.WriteLine($"1.Tennis Shoes 2.Slip On 3.Flip Flops 4.Heels 5.Flats 6.Mules");
            Console.WriteLine();
            string shoes = Console.ReadLine();

            int.TryParse(shoes, out ShoeChoice);

            switch ((ShoeStyle)ShoeChoice)
            {
                case ShoeStyle.TennisShoes:
                    Console.WriteLine("You have chosen our Strolling collection");
                    break;

                case ShoeStyle.SlipOn:
                    Console.WriteLine("You have chosen our EasySlide collection");
                    break;

                case ShoeStyle.FlipFlops:
                    Console.WriteLine("You have chosen our Summer collection");
                    break;

                case ShoeStyle.Heels:
                    Console.WriteLine("You have chosen our SteppingOut collection");
                    break;

                case ShoeStyle.Flats:
                    Console.WriteLine("You have chosen our EasyDoesIt collection");
                    break;

                case ShoeStyle.Mules:
                    Console.WriteLine("You have chosen a $ALE ITEM");
                    break;

            }
            Console.WriteLine("");
            Console.ReadLine();

        }

            


            
    }


//Inheritancep1 switchpr1&2 accessmodifir
} 
       



      



