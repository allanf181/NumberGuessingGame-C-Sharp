/*
 * author: creativecub
 * translator: armelin1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "NumberGuessingGame";
            while (true)
            {
                int randno = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Insira um número de 1 a 100(0 para sair):");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randno)
                    {
                        Console.WriteLine("Baixo, tente novamente.");
                        ++count;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("Alto, tente novamente.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Você adivinhou! O número era {0}!", randno);
                        Console.WriteLine("Demorou {0} {1}.\n", count, count == 1 ? "tentativa" : "tentativas");
                        break;
                    }
                }
            }
        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
