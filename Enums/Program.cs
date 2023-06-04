using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day = Day.Fri;
            Day day3 = Day.Wed;
            Console.WriteLine(day3);
            if (day == Day.Fri)
            {
                Console.WriteLine("Пятница");
                Console.WriteLine((int)day);

                
                if (day == Day.Fri)
                {
                    Console.ReadLine();
                }
                

            }
            
        }
    }
}
