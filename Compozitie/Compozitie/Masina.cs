using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozitie
{
    class Masina
    {
        private Motor motor;

        public int VitezaMaxima
        {
            get
            {
                return (int)(motor.CaiPutere * 1.5);
            }
        }

        public Masina(Motor motor)
        {
            this.motor = motor;
        }


    }
}
