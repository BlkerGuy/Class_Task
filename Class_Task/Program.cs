using System;

namespace Class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            Notebooks notebook = new Notebooks();
            notebook.Brand = "ASUS";
            notebook.Model = "TUF GAMING";
            notebook.Price = 2000;

            notebook.ShowInfo();
            

            // Task 2
            Notebooks notebook2 = new Notebooks("ASUS","ROG STRIX");
            notebook2.Price = 2099;
            notebook2.ShowInfo();


            // Task 3
            Notebooks[] notebooks = new Notebooks[] { notebook, notebook2 };

            int sum = 0;
            int count = 0;
            for (int i = 0; i <notebooks.Length; i++)
            {
                if (notebooks[i]!=null && notebooks[i].Price!=0)    //Burda null ve qiymetini 0 yoxlayiram null
                {                                                   //olmasa'da qiymeti (default) teyin olunmamis ola biler.
                    sum += notebooks[i].Price;
                    count++;
                }
            }
            Console.WriteLine("\nNotebooks Average:"+sum/count);
            
        }                                                   
    }
}
