using System;

namespace StudentInfo
{
    class Info
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("the exam is passed! ");
            }
            else
            {
                Console.WriteLine("The Program text is not Passed !"); ;
            }
            Console.WriteLine("Hello world!");
        }
    }
}
