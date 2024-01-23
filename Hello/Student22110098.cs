using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Student22110098
    {
        private string name;
        private int age;
        private int id;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }

        public Student22110098() 
        {
            Name = "Nguyen Ngoc Hai Anh";
            Age = 18;
            Id = 22110098;
        }
    }
}
