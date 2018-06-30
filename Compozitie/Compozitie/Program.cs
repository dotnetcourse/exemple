using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozitie
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor150CP motor = new Motor150CP();
            Masina masina = new Masina(motor);

            Console.WriteLine($"Masina noastra are viteza maxima {masina.VitezaMaxima}");

            Console.ReadLine();
        }
    }
}
