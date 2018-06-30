using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    abstract class Animal
    {
        // in ani
        private int _varsta;
        // in kg
        private double _greutate;
        // in cm
        private int _inaltime;
        private string _nume;

        public int Varsta
        {
            get { return _varsta; }
        }

        public double Greutate
        {
            get { return _greutate; }
        }

        public int Inaltime
        {
            get { return _inaltime; }
        }

        public virtual string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }

        public Animal(int varsta, double greutate, int inaltime)
        {
            _varsta = varsta;
            _greutate = greutate;
            _inaltime = inaltime;
        }

        public void AMaiTrecutUnAn()
        {
            _varsta = _varsta + 1;
        }

        public void DamMancare(double greutateMancare)
        {
            _greutate = _greutate + greutateMancare;
        }
    }
}
