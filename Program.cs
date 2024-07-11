using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 200;
            object obj = num; //boxing
            //value type variable(int,char) -> rference type variable(obj)
            num = 100; //value of num got changed but type value of obj will remain same.

            Console.WriteLine(num);
            Console.WriteLine(obj);

            int abc = (int)obj; //unboxing
            //reference -> value type variable

            Console.WriteLine(abc);

        }
    }
}
