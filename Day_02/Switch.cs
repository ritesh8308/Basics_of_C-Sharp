using System;

namespace Day_02
{
    class Switch
    {
        static void Main(string[] args)
        {

            Console.Write("Enter day no. (1-7): ");
            int day = int.Parse(Console.ReadLine());
            
            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 or 7 => "Weekend!",
                _ => "Invalid"       // _ is the default
            };
            
            Console.WriteLine(dayName);



/**************************************************************************************************************************************************************************************** 
           Console.Write("Enter day no. (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednsday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday-- Weekend!");
                    break;

                default:
                    Console.WriteLine("Invalid Day: Enter from (1-7)");
                    break;
                
            }  
            
****************************************************************************************************************************************************************************************/

        }
    }
}