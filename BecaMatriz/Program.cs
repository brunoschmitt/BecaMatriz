using System;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cada Becario deverá criar um metódo para calcular a soma da diagonal principal de uma matriz quadrada 3 x 3 
            // O método deverá ter o nome do participante
            // exemplo: CalculaSomaDiagonalPrincipal_Ricardo();

            double[,] matrix;

            Console.WriteLine("Informe o tamanho da matrix quadrada");
            int tamanhoMatrix = int.Parse(Console.ReadLine());

            double soma = 0D;
            matrix = new double[tamanhoMatrix, tamanhoMatrix];
            CalculaSomaDiagonalBruno_Alexandre(matrix, ref soma);
            Console.WriteLine($"Resultado da soma da diagonal principal {soma}");
            Console.Read();


        }

        public static void CalculaSomaDiagonalBruno_Alexandre(double[,] matrix, ref double soma)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Informe o valor da posição {i + 1} {j + 1} da matix quadrada");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma += matrix[i, j];
                    }
                }

            }

        }
    }

}
