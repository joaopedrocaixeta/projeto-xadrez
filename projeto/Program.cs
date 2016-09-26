using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um vslor intereiro");

            int x = int.Parse(Console.ReadLine());

            int y = 2 * x;

            Console.WriteLine("Dobro = " + y);

            Console.ReadLine();

        }
    }
}
