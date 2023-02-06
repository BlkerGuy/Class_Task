using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task
{
    class Notebooks
    {
        public string Brand;
        public string Model;
        public int Price;


        public void ShowInfo()
        {
            Console.WriteLine($"\n Brand:{Brand},\n Model:{Model},\n Price:{Price}");
        }
        public Notebooks()
        {
        }
        public Notebooks(string brand,string model)
        {
            Brand = brand;
            Model = model;

        }
        
    }
}
