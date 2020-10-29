using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheoryExample
{

    class Program
    {
        public int number1; // public number of the Program class - available to everyone
        protected int number2; // protected int - available only within this class - protected και intenal δεν είμαι 100% σίγουρος tbh
        private int number3; // available to this class only
        internal int num4; // available to the namespace TheoryExample
        protected internal int num5; // available in namespace and containing class  - Αυτό και το επόμενο δεν είμαι σίγουρος αν τα έχω καταλάβει σωστά ακόμα
        private protected int num6; // οπότε θα αποφύγω να μαντέψω και να τα ξαναδώ και στο μάθημα...

        static unsafe void Main(string[] args) //To unsafe μπήκε για να μπορώ να βάλω τον Pointer(ήθελε edit και στα properties)
        {

            int x; // x is Value Data Type
            string s; // s is Reference Data Type
            int* y; // y is Pointer Data Type

            Rectangle myR = new Rectangle(10, 5); // creating an instance of the structure i made below
            
        }

        protected struct Rectangle // making a structure type  - Also a Protected modifier for this struct, will only be available within this class
        {
            public int width { get; }
            public int height { get; }
            public Rectangle(int x, int y)
            {
                width = x;
                height = y;
            }
            public int Area ()
            {
                return (width * height);
            }

        }
        enum Season // enum type
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }


    }
}
