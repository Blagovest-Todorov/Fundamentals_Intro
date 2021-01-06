using System;

namespace TimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sumMinutes = min + 30;

            if (sumMinutes > 59)
            {                
                hour = hour + 1;
                
                min = (sumMinutes - 60);
                Console.WriteLine($"{hour} h : {min} m");
            }
            else if (sumMinutes <= 59 && sumMinutes >= 0)
            {
                Console.WriteLine($"{hour} h : {sumMinutes} m");
            }
        }
    }
}
