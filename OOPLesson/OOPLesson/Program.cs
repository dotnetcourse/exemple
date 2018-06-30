using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Caine caine = new Caine(3, 10, 30);
            Console.WriteLine("Cainele latra:");
            caine.Latra();

            Doberman doberman = new Doberman(4, 20, 40);
            Console.WriteLine("Dobermanul latra:");
            doberman.Latra();

            Mastiff mastiff = new Mastiff(5, 40, 50);
            Console.WriteLine("Mastifful latra:");
            mastiff.Latra();
            mastiff.Latra(5);
            mastiff.Nume = "Bernard";
            Console.WriteLine($"Numele cainelui meu este {mastiff.Nume}");
            

            Console.ReadLine();
        }
    }
}
