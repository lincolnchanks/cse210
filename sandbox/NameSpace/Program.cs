namespace programNameSpace
{
    using MyMainSpace.SubSpace1;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            TestClass test = new TestClass(66);
            test.DisplayData();
        }
    }
}
// Namespaces help you organize and separate code.
// It also prevents code collisions, which I assume will happen if you name a variable or class
// the same thing as what someone else names it.