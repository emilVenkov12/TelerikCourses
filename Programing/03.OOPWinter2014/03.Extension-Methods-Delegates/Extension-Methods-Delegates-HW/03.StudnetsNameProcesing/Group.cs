namespace _03.StudnetsNameProcesing
{
    using System;

    public class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}
