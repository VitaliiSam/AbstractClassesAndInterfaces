namespace ClassLibrary1
{
    //IOutuput interface
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
    public class MyArray : IOutput
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
    }
    //IMath interface
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
}
