using System;

namespace exercicioresolvido02matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            mat = new int[M, N];

            for(int i=0; i<M; i++)//linha
            {
                s = Console.ReadLine().Split(' ');
                for(int j=0;j<N; j++)//coluna
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];

            for(int i = 0; i<M; i++)//linha da matriz
            {
                int soma = 0;
                for(int j=0; j<N; j++)//coluna da matriz
                {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }

            for(int i = 0; i<M; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}