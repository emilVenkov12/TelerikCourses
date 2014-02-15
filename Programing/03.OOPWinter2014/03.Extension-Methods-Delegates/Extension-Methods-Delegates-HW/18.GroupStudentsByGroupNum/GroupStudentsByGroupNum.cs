namespace _18.GroupStudentsByGroupNum
{
    using _03.StudnetsNameProcesing;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GroupStudentsByGroupNum
    {
        static void Main()
        {
            List<Student> students = new List<Student>(new Student[] { 
                new Student(
                    "Pesho", "Goshov", 20, "103313", "0123456789", "pesho@abv.bg", 
                    new List<int>(new int[] { 2, 3, 4, 5, 6 }), new Group(2, "Mathematics")),
                new Student(
                    "Gosho", "Peshov", 21, "103312", "0123066782", "gosho@abv.bg", 
                    new List<int>(new int[] { 6, 3, 4, 5, 6 }), new Group(1, "Mathematics")),
                new Student(
                    "Penka", "Goshova", 25, "103306", "0123456781", "penka@abv.bg", 
                    new List<int>(new int[] { 2, 3, 4, 6, 6 }), new Group(4, "Mathematics")),
                new Student(
                    "Ginka", "Goshova", 17, "103306", "0123066783", "ginka@abv.bg", 
                    new List<int>(new int[] { 2, 3, 4, 5, 6 }), new Group(2, "Mathematics"))
            });

            var groupedStudents =
                from stud in students
                group stud by stud.Group.GroupNumber;

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
