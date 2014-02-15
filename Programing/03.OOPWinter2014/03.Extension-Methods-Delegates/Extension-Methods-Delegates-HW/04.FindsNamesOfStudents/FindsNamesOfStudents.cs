namespace _04.FindsNamesOfStudents
{
    using _03.StudnetsNameProcesing;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindsNamesOfStudents
    {
        //04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        static void Main(string[] args)
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

            var result =
                from stud in students
                where stud.Age > 18 && stud.Age < 25
                select new { FistName = stud.FirstName, LastName = stud.LastName };

            foreach (var item in result)
            {
                Console.WriteLine();
                Console.WriteLine("First name: {0}, Last name: {1}", item.FistName, item.LastName);
            }
        }
    }
}
