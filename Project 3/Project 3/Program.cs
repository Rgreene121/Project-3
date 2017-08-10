using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
        
    public class Program
    {
        static void Main(string[] args)
        {
            
            Constructor cr = new Constructor("Rabi", "Amelia");
            cr.US();
            DepartmentStore ds = new DepartmentStore();
            ds.StylePick();
            Shirts st = new Shirts();
            st.ShirtO();
            Shoes sh = new Shoes();
            sh.ShoesO();
            Pants pt = new Pants();
            pt.PantsDeptment();

            //int x = 30 * 70;
            //newbalance = x;


            Console.ReadLine();

        }
        

    }

}

