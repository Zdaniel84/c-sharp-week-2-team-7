using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Classes
{
    class Department
    {
        public Department(int departmentId, string name)
        {
            this.DepartmentId = departmentId;
            this.Name = name;
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }

    }
}
