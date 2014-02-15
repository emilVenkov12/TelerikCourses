namespace _03.StudnetsNameProcesing
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Group Group { get; set; }

        public Student(string firstName, string lastName, int age, string fN, string tel, string email, List<int> marks, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.Group = group;
        }

        public override string ToString()
        {
            return String.Format("First name: {0}, Last name: {1}, Age: {2},\nFN: {3}, Telephone: {4},\nEmail: {5}, Marks: {6},\nGroup number: {7}, Department name: {8}",
                this.FirstName, this.LastName, this.Age, this.FN, this.Tel, this.Email, String.Join(", ", this.Marks.ToArray()), 
                this.Group.GroupNumber, this.Group.DepartmentName);
        }
    }
}
