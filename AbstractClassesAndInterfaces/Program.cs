using System;
using ClassLibrary1;

namespace AbstractClassesAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 10, 20, 30, 40 };
            MyArray arr = new MyArray(data);
            //Output
            arr.Show();
            arr.Show("This is my array");
            //Math: Max, Min, Avg, Search
            Console.WriteLine("Math interface");
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Avg());
            Console.WriteLine("Search value: 30 - " + arr.Search(30));
            Console.WriteLine("Search value: 90 - " + arr.Search(90));
        }
    }

      

}
