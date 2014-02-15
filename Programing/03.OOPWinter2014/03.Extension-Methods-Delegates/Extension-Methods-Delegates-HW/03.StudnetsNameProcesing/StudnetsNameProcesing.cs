namespace _03.StudnetsNameProcesing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudnetsNameProcesing
    {
        //03.Write a method that from a given array of students finds all
        //students whose first name is before its last name alphabetically. Use LINQ query operators.

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

            var result =
                from stud in students
                where stud.FirstName.CompareTo(stud.LastName) > 0
                select stud;

            foreach (var item in result)
            {
                Console.WriteLine();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
