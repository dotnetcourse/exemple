using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    abstract class Mamifer : Animal
    {
        public Mamifer(int varsta, double greutate, int inaltime) : base(varsta, greutate, inaltime)
        {
            
        }

        public void Alapteaza()
        {
            Console.WriteLine("Acesta animal alapteaza.");
        }
    }
}
