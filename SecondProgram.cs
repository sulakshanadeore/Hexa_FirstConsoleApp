using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechApp
{
    internal class SecondProgram
    {
        //named constants
        enum Weekdays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        

        struct Person
        {
           public string PersonName;
          public  string City;

            public void DisplayPersonInfo()
            {
                Console.WriteLine($"Person Name= {PersonName}");
                Console.WriteLine($"Person City= {City}");


            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            
            Person person = new Person();
            
            person.PersonName = "Ajit";
            person.City = "Indore";

            person.DisplayPersonInfo();

            Console.WriteLine("---------------------");

            Console.WriteLine("Enter a week day as a number");
            string s=Console.ReadLine();
            
            
            Weekdays w =(Weekdays) Enum.Parse(typeof(Weekdays), s, false);
            switch (w)
            {
                case Weekdays.Sunday:
                    Console.WriteLine("Enjoy your weekend");
                    break;
                case Weekdays.Monday:
                    Console.WriteLine("Enjoy your first day");
                    break;
                case Weekdays.Tuesday:
                    Console.WriteLine("Enjoy your  day");
                    break;
                case Weekdays.Wednesday:
                    Console.WriteLine("Enjoy your  day");

                    break;
                case Weekdays.Thursday:
                    Console.WriteLine("Enjoy your  day");
                    break;
                case Weekdays.Friday:
                    Console.WriteLine("Enjoy your  day");
                    break;
                case Weekdays.Saturday:
                    Console.WriteLine("Enjoy your weekend");
                    break;
                default:
                    break;
            }





            //DateTime dt=DateTime.Now;
            //int hr=dt.Hour;
            //string greet = (hr < 18) ? "Good Morning" : "Good evening";
            //Console.WriteLine(greet);

            ////Jagged Array: every dept can have different number of employees.

            //int[][] jaggedArr = new int[][] 
            //{ 
            //new int[] {10,20 },
            //new int[]{100,200,300 },
            //new int[]{1000,2000,3000,4000 } ,
            //new int[] {1}
            //};
            //foreach (int[] item in jaggedArr)
            //{
            //    foreach (var element in item)
            //    {
            //        Console.Write(element + "\t");
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
