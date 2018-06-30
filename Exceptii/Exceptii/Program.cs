using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptii
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var content = File.ReadAllText(@"C:\Temp\Exceptii\Exemplu.txt");
                Console.WriteLine(content);
            }
            
            catch (FileNotFoundException)
            {
                Console.WriteLine("A aparut o problema va rugam sa va asigurati ca numele fisierului este Exemplu.txt");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine(@"Va rugam verificati ca calea catre fisierul Exemplu.txt este C:\Temp\Exceptii");
            }
            catch (Exception ex)
            {
                Console.WriteLine("A aparut o problema!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Aici curatam resursele");
            }
            

            Console.ReadLine();
        }
    }
}
