namespace _19.GroupStudsByGroupNumLambda
{
    using _03.StudnetsNameProcesing;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GroupStudsByGroupNumLambda
    {
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

            var groupedStudents = students.GroupBy(stud => stud.Group.GroupNumber);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine("\nNew Group:");
                foreach (var stud in group)
                {
                    Console.WriteLine();
                    Console.WriteLine(stud);
                }
            }
        }
    }
}
