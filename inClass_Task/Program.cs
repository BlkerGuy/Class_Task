using System;

namespace inClass_Task
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Ali Gafarov");
            Human human1 = new Human("Ali Gafarov",20);

            Students student = new Students();
            student.FullName = "Ali Gafarov";
            student.Age = 30;
            student.GroupNo = "P138";
            student.Point = 100;

            student.ShowInfo();

        }
    }
}
