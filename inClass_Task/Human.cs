using System;
using System.Collections.Generic;
using System.Text;

namespace inClass_Task
{
     internal class Human
    {
        public string Fullname;
        public byte Age;

        public Human(string name)
        {
            Console.WriteLine("Human created! with Fullname");
            Fullname = name;
            Age = 26;
        }
        public Human(string name,byte age)
        {
            Console.WriteLine("Human created! with Fullname and Age");
            Fullname = name;
            Age = age;
        }

    }
}
