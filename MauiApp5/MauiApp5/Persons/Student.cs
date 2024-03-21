using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5.Persons
{
    internal class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int ID { get; set; }

        public Student(string name, string department, int id)
        {
            Name = name;
            Department = department;
            ID = id;
        }
    }
}
