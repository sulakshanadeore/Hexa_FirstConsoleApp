using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechApp
{
    internal class SecondProgram
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Now;
            int hr=dt.Hour;
            string greet = (hr < 18) ? "Good Morning" : "Good evening";
            Console.WriteLine(greet);

            //Jagged Array: every dept can have different number of employees.

            int[][] jaggedArr = new int[][] 
            { 
            new int[] {10,20 },
            new int[]{100,200,300 },
            new int[]{1000,2000,3000,4000 } ,
            new int[] {1}
            };
            foreach (int[] item in jaggedArr)
            {
                foreach (var element in item)
                {
                    Console.Write(element + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
