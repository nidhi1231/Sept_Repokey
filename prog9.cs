using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    class Prog9
    {
        // 29 sept 22

        int i = 20;// global variable
        static void Main()
        {
            int i = 100; // local variable
            Console.WriteLine(i); 
            Main1(); // main1 method calling
            Console.ReadLine();
        }

        static void Main1() //  Main1 method declaration
        {
            Prog9 p1 = new Prog9();// create p1 object using new keyword
            Console.WriteLine(p1.i);// object p1 access variable i , i is( global vairable)
        }
    }
}
