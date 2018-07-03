using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii
{
    class Program
    {
        static void Main(string[] args)
        {
           //LINQ

            Animal animal1 = new Animal();
            animal1.Rasa = "Caine";
            animal1.Varsta = 2;

            Animal animal2 = new Animal();
            animal2.Rasa = "Pisica";
            animal2.Varsta = 5;

            Aliment aliment1 = new Aliment();
            aliment1.Denumire = "Lapte";
            aliment1.DataExpirare = DateTime.Now.AddMonths(1);
            aliment1.CodeDeBare = "123";

            Aliment aliment2 = new Aliment();
            aliment2.Denumire = "Carne";
            aliment2.DataExpirare = DateTime.Now.AddMonths(12);
            aliment2.CodeDeBare = "1234";

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(animal1);
            //arrayList.Add(animal2);
            //arrayList.Add(aliment1);

            Console.ReadLine();

            //foreach(Animal animal in arrayList)
            //{
            //    Console.WriteLine(animal.Rasa);
            //}

            List<Animal> animale = new List<Animal>()
            {
                new Animal(){ Rasa = "Gasca", Varsta=2},
                new Animal(){ Rasa="Rata", Varsta=3}
            };

            animale.Add(animal1);
            animale.Add(animal2);


            foreach (Animal animal in animale)
            {
                Console.WriteLine(animal.Rasa);
            }

            //Dictionary<TKey,TValue>

            //Dictionary<string, Aliment> myDictionary = new Dictionary<string, Aliment>();
            //myDictionary.Add(aliment1.CodeDeBare, aliment1);
            //myDictionary.Add(aliment2.CodeDeBare, aliment2);

            //Console.WriteLine(myDictionary["1234"].Denumire);

            Console.ReadLine();
        }

    }

    class Animal
    {
        public string Rasa { get; set; }

        public int Varsta { get; set; }

    }

    class Aliment
    {
        public string CodeDeBare { get; set; }
        public string Denumire { get; set; }

        public DateTime DataExpirare { get; set; }
    }
}
