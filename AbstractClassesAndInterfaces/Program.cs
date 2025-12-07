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
            arr.Show();
            arr.Show("This is my array");
        }
    }

      

}
