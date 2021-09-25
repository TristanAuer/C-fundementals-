using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("hello World");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is Default. It will be executed if no either case is evaluated.");
                    break;

            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the begining of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!");
                    break;
            }

            //Challenge
            //Ask the user how they are doing scale 1 to 5, capture input run it through switch output different responce for each value, and if they respond out of range let them know.
            Console.WriteLine("On a scale of 1 to 5 how are you feeling? 5 being a great day!");
            int mood = Convert.ToInt32(Console.ReadLine());
            
            switch (mood)
            {
                case 1:
                    Console.WriteLine("What can I do to improve your day?");
                    break;
                case 2:
                    Console.WriteLine("I think you need to hear a dad joke");
                    break;
                case 3:
                    Console.WriteLine("indecisive?");
                    break;
                case 4:
                    Console.WriteLine("So Close.");
                    break;
                case 5:
                    Console.WriteLine("Looks like your feeling great!");
                    break;
                default:
                    Console.WriteLine("Looks like you didnt read the instructions.");
                    int mood = Convert.ToInt32(Console.ReadLine());
                    break;
            
            }
                
                
            Console.ReadKey();
        }
    }
}
