using System;
using System.Collections;

namespace CollectionsApplication
{
    class ActionClass
    {
        public void PrintInt() {//声明一个无返回值、无参数的方法
            Console.WriteLine("PrintInt");
        }
        public void PrintString(string str) {//声明一个无返回值、有参数的方法

            Console.WriteLine(str);
        }
        public void PrintStrAndInt(string str,int myInt) {//声明一个无返回值、有参数的方法

            Console.WriteLine(str+myInt);
        }

    }
    class Program
    {

        static void Main(string[] args) {
            ActionClass ac = new ActionClass();
            Action a1 = ac.PrintInt;
            a1();

            Action<string> a2 = ac.PrintString;
            a2("PrintString");

            Action<string, int> a3 = ac.PrintStrAndInt;
            a3("PrintStrAndInt", 2019);

            Console.ReadKey();
        }
    }
}
