namespace _16.UsingJoinOperator
{
    using _03.StudnetsNameProcesing;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UsingJoinOperator
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

            Group[] groups = new Group[]
            {
                new Group(15, "Mathematics"),
                new Group(3, "Physics"),
                new Group(1, "Chemistry")
            };

            var selectedStuds =
                from gr in groups
                join stud in students on gr.DepartmentName equals stud.Group.DepartmentName
                where gr.DepartmentName == "Mathematics"
                select new { Department = stud.Group.DepartmentName, FullName = stud.FirstName + " " + stud.LastName };

            foreach (var stud in selectedStuds)
            {
                Console.WriteLine("First name: {0}, Deparment: {1};", stud.FullName, stud.Department);
            } 
        }
    }
}
