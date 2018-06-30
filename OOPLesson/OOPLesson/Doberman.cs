using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    class Doberman : Caine
    {
        public Doberman(int varsta, double greutate, int inaltime) : base(varsta, greutate, inaltime)
        {

        }

        public override void Latra()
        {
            Console.WriteLine("Hamham");
        }
    }
}
