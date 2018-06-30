using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    class Pisica : Mamifer
    {
        public Pisica(int varsta, double greutate, int inaltime) : base(varsta, greutate, inaltime)
        {

        }

        public void Meauna()
        {
            Console.WriteLine("Meau");
        }
    }
}
