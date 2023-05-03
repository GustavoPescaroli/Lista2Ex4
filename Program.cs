using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex4
{

    
        internal class Program
        {
            static void Main(string[] args)
            {
                int b;
                int h;
                int a;

                Console.Write("insira o Valor da Base: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("insira o Valor da altura: ");
                h = int.Parse(Console.ReadLine());

                a = b * h;
                 Console.WriteLine("valor da area {0}", a);

                if (a > 100)
                    Console.WriteLine("Terreno Grande.");


                

                
                



                
            }
        }
    
}
    

