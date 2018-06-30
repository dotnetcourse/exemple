using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    class Caine : Mamifer
    {
        public Caine(int varsta, double greutate, int inaltime) : base(varsta, greutate, inaltime)
        {

        }

        public virtual void Latra()
        {
            Console.WriteLine("Ham ham");
        }
    }
}
