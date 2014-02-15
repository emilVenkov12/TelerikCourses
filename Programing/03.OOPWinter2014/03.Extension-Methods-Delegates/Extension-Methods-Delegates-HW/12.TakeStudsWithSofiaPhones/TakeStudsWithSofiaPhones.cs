namespace _12.TakeStudsWithSofiaPhones
{
    using _03.StudnetsNameProcesing;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class TakeStudsWithSofiaPhones
    {
        static void Main()
        {
            //Press F12 while cursor is on Student to see deffinition
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

            var selectedStudents =
                from stud in students
                where stud.Tel.StartsWith("02")
                orderby stud.FirstName
                select stud;

            foreach (var stud in selectedStudents)
            {
                Console.WriteLine();
                Console.WriteLine(stud.ToString());
            }
        }
    }
}
