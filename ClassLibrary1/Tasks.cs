using System.Globalization;

namespace ClassLibrary1
{
    //IOutuput interface
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
    //IMath interface
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    //ISort interface
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);

    }
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] numbers;
        public MyArray (int[] numbers)
        {
            this.numbers = numbers;
        }
        public void Show()
        {
            Console.WriteLine("Elements of arrays");
            foreach (int i in numbers)
            {  
                Console.WriteLine(i);
            }

        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
        //IMath
        public int Max()
        {
            int max = numbers[0];
            foreach (int n in numbers)
            {
                if(n > max)
                {
                    max = n;
                }    
            }
            return max;
        }
        public int Min()
        {
            int min = numbers[0];
            foreach (int n in numbers)
            {
                if (n < min)
                {
                    min = n;
                }
            }
            return min;
        }
        public float Avg()
        {
            int sum = numbers[0];
            foreach(int n in numbers)
            { 
                sum += n; 
            }
            return (float)sum / numbers.Length;

        }
        public bool Search(int valueToSearch)
        {
            foreach (int n in numbers)
            {
                if(n == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
        //Sort
        public void SortAsc()
        {
            Array.Sort(numbers);
        }
        public void SortDesc()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            SortDesc();
        }
    }        
}
