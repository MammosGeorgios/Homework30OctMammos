using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DuoNumbersExample
{
    public class DuoNumbers
    {
        public int number1;
        public int number2;

        public DuoNumbers(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public DuoNumbers()
        {
            this.number1 = 0;
            this.number2 = 1;
        }


        // change number1 and number 2 method
        void UpdateNumbers (int n1, int n2)
        {
            this.number1 = n1;
            this.number2 = n2;
        }

        public int Add(int a, int b)
        {
            UpdateNumbers(a, b);
            return (Add());
        }
        public int Sub(int a,int b)
        {
            UpdateNumbers(a, b);
            return (Sub());
        }
        public int Mul(int a, int b)
        {
            UpdateNumbers(a, b);
            return (Mul());
        }
        public int Div(int a, int b)
        {
            UpdateNumbers(a, b);
            return (Div());
        }
        
       // Σε περίπτωση που βάλω αρχικά νούμερα

        public int Add()
        {
            return (this.number1 + this.number2);
        }
        public int Sub()
        {
            return (this.number1 - this.number2);
        }
        public int Mul()
        {
            return (this.number1 * this.number2);
        }
        public int Div()
        {
            if (this.number2 == 0) return (this.number1 / 1);
            else return (this.number1 / this.number2);
        }

        // Print μέθοδοι
        public void PrintNumbers()
        {
            Console.WriteLine($"The numbers given are {number1} and {number2}");
        }
        public void PrintAdd()
        {
            Console.WriteLine($"{number1} + {number2} = {Add()}");
        }
        public void PrintSub()
        {
            Console.WriteLine($"{number1} - {number2} = {Sub()}");
        }
        public void PrintMul()
        {
            Console.WriteLine($"{number1} * {number2} = {Mul()}");
        }
        public void PrintDiv()
        {
            if (number2 == 0) Console.WriteLine($"{number1} / {number2} = {Div()} - You tried to divide with zero!");
            else Console.WriteLine($"{number1} + {number2} = {Div()}");
        }


        // Μέθοδος που θα κάνει το print τα πάντα
        public void PrintAll() 
        {
            PrintNumbers();
            PrintAdd();
            PrintSub();
            PrintMul();
            PrintDiv();
        }
    }
}
