using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    public class Constructor
    {
        string fName;
        string sName;

        public Constructor(string First, string Second)
        {
            fName = First;
            sName = Second;

        }
        public void US()
        {


            Console.WriteLine("This is Rabi and Amelia's Department Store");
            Console.ReadLine();
        }


    }
}
//  enum HatsStyle
//    {
//        Fedora = 1,
//        Beret,
//        Straw,
//        Cloche,
//        SchoolBoy,
//        Sun
                        
//    }

//    class Hats
//{
//    public void HatDepartment()
//    {

//        int HatsChoice;

//        Console.WriteLine("Which Hat style do you prefer \n 1.Fedora, \n 2.Beret, \n 3.Straw, \n 4.Cloche, \n 5.SchoolBoy, \n 6.Sun");

//        string Hats = Console.ReadLine();

//        int.TryParse(Hats, out HatsChoice);

//        switch ((HatsStyle)HatsChoice)
//        {
//            case HatsStyle.Fedora:
//                Console.WriteLine("This hat says it all");
//                break;

//            case HatsStyle.Beret:
//                Console.WriteLine("This hat says I am important");
//                break;

//            case HatsStyle.Straw:
//                Console.WriteLine("Although this hat is durable it's also fasionable");
//                break;

//            case HatsStyle.Cloche:
//                Console.WriteLine("Classy Choice!");
//                break;

//            case HatsStyle.SchoolBoy:
//                Console.WriteLine("You have selected our hip yougster look");

//                break;

//            case HatsStyle.Sun:
//                Console.WriteLine("You have selected our hand crafted sun hats");
//                break;

//            default:
//                Console.WriteLine("Thank you for shopping with us today. Please come again");
//                break; 