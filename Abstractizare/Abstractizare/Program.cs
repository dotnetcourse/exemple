using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractizare
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonGresit telefon = new TelefonGresit();
            telefon.GasesteCeaMaiPuternicaAntena();
            telefon.VerificaNumarValid("074324234");
            telefon.VerificaCredit();
            telefon.CreazaConectiunea();

            TelefonCorect telefon2 = new TelefonCorect();
            telefon2.Apeleaza("0724332432423");

        }
    }
}
