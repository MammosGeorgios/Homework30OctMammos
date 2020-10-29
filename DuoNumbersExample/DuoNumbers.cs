using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        // Δεν κατάλαβα γιατί θέλουμε οι μέθοδοι να έχουν arguments αλλά να οι μέθοδοι όπως ζητήθηκαν
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a,int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b)
        {
            return (a * b);
        }
        public int Div(int a, int b)
        {
            if (b == 0) return (0);
            else return (a / b);
        }

        // Προσωπικά περίμενα να μας ζητηθεί το παρακάτω (θα χρησιμοποιήσω τις παραπάνω μεθόδους γιατί μπορώ! Αλλά νομίζω οτι δεν ήταν απαραίτητες
        // για την λειτουργία που περιμένουμε από αυτή τη κλάση.) δηλαδή μέθοδοι χωρίς arguments

        public int Add()
        {
            return (Add(this.number1, this.number2));
        }
        public int Sub()
        {
            return (Sub(this.number1, this.number2));
        }
        public int Mul()
        {
            return (Mul(this.number1, this.number2));
        }
        public int Div()
        {
            return (Div(this.number1, this.number2));
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
            if (number2 == 0) Console.WriteLine("I can't divide with zero!");
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
