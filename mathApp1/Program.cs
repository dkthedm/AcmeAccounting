using System;


namespace MathApp
{
    class Program
    {
        static void Main()
        {
            //const int maxNumber = 10000000;
            Console.WriteLine("Let's do a math problem. Enter a value and we will multiply it by 50.");


            string userValue = Console.ReadLine();
            int y = Convert.ToInt32(userValue);
            int x = 50;

            Console.WriteLine("answer is " + y * x);
            Console.ReadLine();

            Console.WriteLine("now let's add a value to 25");


            string userValue1 = Console.ReadLine();
            int a = Convert.ToInt32(userValue1);
            int b = 25;
            int total = a + b;

            Console.WriteLine("Answer is:" + total);
            Console.ReadLine();

            Console.WriteLine("now let's divide a value by 12.5");


            string divisionValue = Console.ReadLine();
            int c = Convert.ToInt32(divisionValue);
            float d = 12.5f;
            float divTotal = c / d;

            Console.WriteLine("Answer is:" + divTotal);
            Console.ReadLine();

            Console.WriteLine("now type in a value and let's see if it is greater than 50");
            string boolValue = Console.ReadLine();
            int e = Convert.ToInt32(divisionValue);
            int f = 50;

            bool boolEquation = e >= f;
            Console.WriteLine("Answer is:" + boolEquation);
            Console.ReadLine();

            Console.WriteLine("now let's divide a value by 7 and show the remainder");


            string remainderValue = Console.ReadLine();
            int g = Convert.ToInt32(divisionValue);
            int h = 7;
            int remainderTotal = g % h;

            Console.WriteLine("Answer is:" + remainderTotal);
            Console.ReadLine();

        }
    }
}


