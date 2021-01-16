using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "Prepare to Dev";
            course1.StudentName = "Jhon";
            course1.WatchingRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.StudentName = "Jane";
            course2.WatchingRate = 65;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.StudentName = "Jessie";
            course3.WatchingRate = 6;

            //Console.WriteLine(course1.CourseName + " " + course1.WatchingRate);

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.StudentName + " " + course.WatchingRate);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string StudentName { get; set; }
        public int WatchingRate { get; set; }
    }
}
