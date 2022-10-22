using System;

namespace exercicioresolvido1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

            for(int i = 1; i<=10; i++)
            {
                int resultado = i * numero;
                Console.WriteLine(i + " x " + numero + " = " + resultado);
            }
        }
    }
}
