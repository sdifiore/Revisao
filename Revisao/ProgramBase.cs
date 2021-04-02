using System;

namespace Revisao
{
    public static class ProgramBase
    {
        public static void PrintArray(double[] array)
        {
            Console.WriteLine();

            foreach (var item in array)
                Console.WriteLine(item);

            Console.WriteLine();
        }

        public static int GetDimension()
        {
            Console.WriteLine();
            Console.WriteLine("Quantos dados deseja classificar?");
            Console.WriteLine("ENTER para 100");
            var ehNumero = int.TryParse(Console.ReadLine(), out int dimensao);

            if (!ehNumero)
                dimensao = 100;

            return dimensao;
        }

        public static int GetSentido()
        {
            var opcao = 0;

            while (opcao != 1 && opcao != 2)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha a opção de classificação:");
                Console.WriteLine("[1] Ascendente    [2] Descendente");
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());
            }

            return opcao;
        }

        public static double[] GetArray(int dimensao)
        {
            double[] sortArray = new double[dimensao];

            for (int i = 0; i < dimensao; i++)
            {
                var ehNumero = false;

                while (!ehNumero)
                {
                    Console.WriteLine($"Digite o valor do {i + 1}º elemento:");
                    ehNumero = double.TryParse(Console.ReadLine(), out sortArray[i]);
                }
            }

            return sortArray;
        }
    }
}
