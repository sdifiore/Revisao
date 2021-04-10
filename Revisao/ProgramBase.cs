using System;

namespace Revisao
{
    public static class ProgramBase
    {
        public static void PrintArray(CronArray array)
        {
            Console.WriteLine();

            foreach (var item in array.ArrayValues)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine($"Tempo de processamento: {array.Duracao}");
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

        public static int GetPesquisa()
        {
            var opcao = 0;

            while (opcao != 1 && opcao != 2)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha o tipo de pesquisa:");
                Console.WriteLine("[1] Sequencial    [2] Binária");
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());
            }

            return opcao;
        }

        public static int GetListaSeqOpcao()
        {

            var opcao = 0;

            while (opcao < 1 || opcao > 3)
            {
                Console.WriteLine();
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("[1] Inserir valor");
                Console.WriteLine("[2] Eliminar valor");
                Console.WriteLine("[3] Encerrar");
                opcao = int.Parse(Console.ReadKey().KeyChar.ToString());
            }

            return opcao;
        }

        public static void Cabecalho()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========================================================================");
            Console.WriteLine();
        }

        public static void Fim()
        {
            Console.WriteLine();
            Console.WriteLine("===========================================================================");
            Console.WriteLine();
        }
    }
}
