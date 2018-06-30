using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    class Mastiff : Caine
    {
        public override string Nume
        {
            get { return $"Mastifful {base.Nume}"; }
            set => base.Nume = value;
        }

        public Mastiff(int varsta, double greutate, int inaltime) : base(varsta, greutate, inaltime)
        {

        }

        public override void Latra()
        {
            Console.WriteLine("Ham");
        }

        public int Latra(int numarLatrat)
        {
            for (int i = 0; i< numarLatrat; i++)
            {
                Latra();
            }

            return numarLatrat;
        }
    }
}
