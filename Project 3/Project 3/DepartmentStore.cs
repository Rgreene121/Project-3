﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{

    enum StyleOptions
    {
        Shirts = 1,
        Shoes,
        Pants,
        Hats
    }

    public class DepartmentStore
    {//base class


        public void StylePick ()
        {
            Shirts shirtie = new Shirts();
            Pants panties = new Pants();
            Shoes shoeies = new Shoes();

            int StyleChoice;

            Console.WriteLine($"Welcome to RAD, which department would you like to shop from 1.Shirts or 2.Shoes or 3.Pants or 4.Hats?");

            string Style = Console.ReadLine();

            int.TryParse(Style, out StyleChoice);

            switch ((StyleOptions)StyleChoice)
            {
                case StyleOptions.Shirts:
                    Console.WriteLine("Welcome to the Shirt department. Which style of shirt would you like?");
                    shirtie.ShirtO();

                    break;

                case StyleOptions.Shoes:
                    Console.WriteLine("Welcome to the Shoes department.Which style of Shoes would you like?");
                    shoeies.ShoesO();
                    break;

                case StyleOptions.Pants:
                    Console.WriteLine("Welcome to the Pants department.Which style of Pants would you like?");
                    panties.PantsDeptment();
                    break;

                case StyleOptions.Hats:
                    Console.WriteLine("Welcome to the Hat department. Which style of Hat would you like?");
                    break;

                default:
                    Console.WriteLine("Thank you for shopping with us today. Please come again");
                    break;






            }


        }
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

            Console.WriteLine($"Please select a style \n 1.Flower Print, \n 2.Animal Print, \n 3.Crop Style, \n 4.Button Down \n 5.Baby Doll Style \n 6.Hooded Top");

            string Shirts = Console.ReadLine();

            int.TryParse(Shirts, out ShirtChoice);

            
            switch ((ShirtStyle)ShirtChoice)
            {
                case ShirtStyle.FlowerPrint:
                    
                    //int y = 500;

                    Console.WriteLine("You have chosen our Spring collection. your total is");
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
            Console.WriteLine();

                        

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

           Console.WriteLine($"Welcome to the shoe department. What style of shoe would you like today.\n 1.TennisShoes \n 2.SlipOn \n 3.FlipFlops \n 4.Heels \n 5.Flats \n 6.Mules");
            //Console.WriteLine();
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
                    Console.WriteLine("Mules are 20% off the original price of $70.00.");
                    break;
                

            }
            Console.WriteLine("");
            Console.ReadLine();

        }

            


            
    }


//Inheritancep1 switchpr1&2 accessmodifir
} 
       



      



