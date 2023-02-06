using System;
using System.Collections.Generic;
using System.Text;

namespace inClass_Task
{
     class Students
    {
        public string FullName;
        public byte Age;
        public string GroupNo;
        public byte Point;

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName}  Age: {Age}  GroupNo: {GroupNo} Point: {Point}");
        }
    }
}
