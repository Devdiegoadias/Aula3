using System;

namespace BoxingUnboxingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            object o = a;

            int b = (int)o;
        }
    }
}
