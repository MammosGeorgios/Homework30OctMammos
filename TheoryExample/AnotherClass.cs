using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryExample
{
    public class AnotherClass // public class
    {


    }

    internal class IMadeAClassInTheSameFileWOW //internal class
    {
        static int x; // static variable
        int y; // instance variable
        private int[] t = new int[10]; // int[0] will be an array element

        public void DoSomething()
        {
            x = 2; // don't have to write this because i made x a static variable for this class
            this.y = 3;
        }

        public void DoSomething(int a, int b , out int sum) //value parameters a and b + out parameter c
        {
            int local = 3; // local variable
            x = a;
            this.y = b;
            sum = a + b;
        }

        public void DoSomething(int[] array) // reference parameter
        {
            x = array.Length;
            this.y = 2;
        }
        
    }


}
