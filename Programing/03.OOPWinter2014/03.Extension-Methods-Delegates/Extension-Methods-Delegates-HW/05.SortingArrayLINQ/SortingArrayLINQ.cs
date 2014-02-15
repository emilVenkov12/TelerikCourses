namespace _05.SortingArrayLINQ
{
    using _03.StudnetsNameProcesing;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortingArrayLINQ
    {
        //05.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort
        //the students by first name and last name in descending order. Rewrite the same with LINQ.

        static void Main()
        {
            Student[] students = new Student[] { 
                new Student(
                    "Pesho", "Goshov", 20, "103313", "0123456789", "pesho@abv.bg", 
                    new List<int>(new int[] { 2, 3, 4, 5, 6 }), new Group(2, "Mathematics")),
                new Student(
                    "Gosho", "Peshov", 21, "103312", "0123456782", "gosho@abv.bg", 
                    new List<int>(new int[] { 6, 3, 4, 5, 6 }), new Group(1, "Mathematics")),
                new Student(
                    "Penka", "Goshova", 24, "103311", "0123456781", "penka@abv.bg", 
                    new List<int>(new int[] { 2, 3, 4, 6, 6 }), new Group(4, "Mathematics")),
                new Student(
                    "Ginka", "Goshova", 22, "103323", "0123456783", "ginka@abv.bg", 
                    new List<int>(new int[] { 2, 3, 4, 5, 6 }), new Group(4, "Mathematics"))
            };

            var sortedWithLambda = students.OrderBy(stud => stud.FirstName).ThenBy(stud => stud.LastName);

            var sortedWithLINQ =
                from stud in students
                orderby stud.FirstName, stud.LastName
                select stud;

            Console.WriteLine("Sorted with lambda: ");
            foreach (var item in sortedWithLambda)
            {
                Console.WriteLine();
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Sorted with LINQ: ");
            foreach (var item in sortedWithLINQ)
            {
                Console.WriteLine();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
