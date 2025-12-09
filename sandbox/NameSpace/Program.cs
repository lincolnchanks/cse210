namespace programNameSpace
{
    // using MyMainSpace;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            MyMainSpace.TestClass test = new MyMainSpace.TestClass(66);
            test.DisplayData();
        }
    }
}