using System;

namespace Aula3_Stack_Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 2;
            int j = i;

            j = 10;
            */

            class1 obj = new class1();
            obj.i = 10;

            class1 obj2 = obj;
            obj2.i = 20;

            int i = 123;      // "i" is a value type
            object o = i;     // boxing "i" into "o"
            int j = (int)o;   // unboxing "o" into "j"
        }
    }

    public class class1
    {
        public int i;
    }


}
