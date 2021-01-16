using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] courses = new string[] { "kurs1", "kurs2", "kurs3" };
            List<string> courses2 = new List<string>();

            //for (int i = 0; i < courses.Length; i++)
            //{
            //    Console.WriteLine(courses[i]);
            //}
            courses2.Add("a,b,c");

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

            foreach (var course in courses2)
            {
                Console.WriteLine(course);
            }

        }
    }
}
