namespace MyMainSpace
{
    class TestClass
    {
        private int _attribute;

        public TestClass(int number)
        {
            _attribute = number;
        }
        public void DisplayData()
        {
            Console.WriteLine(_attribute);
        }
    }
}