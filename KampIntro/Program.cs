using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryLabel = "Category";
            int studentCount = 32000;
            double faizRate = 1.45;
            bool signInSystem = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Azalış");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Artıs");
            }
            else
            {
                Console.WriteLine("Equals");
            }

            if (signInSystem = true)
            {
                Console.WriteLine("Options button for User");
            }
            
            else
            {
                Console.WriteLine("Sign in Button");
            }

            Console.WriteLine(categoryLabel);



        }
    }
}
