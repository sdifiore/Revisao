using System;

namespace Revisao
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("=====================");
                Console.WriteLine("[1] É Primo");
                Console.WriteLine("[2] Boletim");
                Console.WriteLine("[3] Novo Boletim");
                Console.WriteLine("[4] Buble Sort");
                Console.WriteLine("[5] Selection Sort");
                Console.WriteLine("[6] Insection Sort");
                Console.WriteLine("[7] Pesquisa");
                Console.ForegroundColor = ConsoleColor.White;

                var ok = false;
                int opcao = 0;

                while (!ok)
                    ok = int.TryParse(Console.ReadLine(), out opcao);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        XeqPrimo();
                        break;
                    case 2:
                        XeqBoletimEscolar();
                        break;
                    case 3:
                        XeqNovoBoletim();
                        break;
                    case 4:
                        XeqBubbleSort();
                        break;
                    case 5:
                        XeqSelectionSort();
                        break;
                    case 6:
                        XeqInserctionSort();
                        break;
                    case 7:
                        XeqPesquisa();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void XeqPrimo()
        {
            Cabecalho();
            
            for (int i = 2; i < 21; i++)
            {
                if (Numero.IsPrime(i))
                    Console.WriteLine(i);
            }

            Fim();
        }

        private static void XeqBoletimEscolar()
        {
            var boletim = new BoletimEscolar();

            Console.WriteLine("Nome do aluno: ");
            boletim.Aluno = Console.ReadLine();
            Console.WriteLine("1ª nota: ");
            boletim.Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2ª nota: ");
            boletim.Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("3ª nota: ");
            boletim.Nota3 = float.Parse(Console.ReadLine());

            Cabecalho();
            Console.WriteLine($"A média do aluno {boletim.Aluno} é {boletim.Media}");
            Fim();
        }

        private static void XeqNovoBoletim()
        {
            var boletim = new NovoBoletim();

            Console.WriteLine("Nome do aluno: ");
            boletim.Aluno = Console.ReadLine();
            Console.WriteLine("Quantas notas: ");
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i + 1}ª nota: ");
                boletim.Notas.Add(float.Parse(Console.ReadLine()));
            }

            Cabecalho();
            Console.WriteLine($"A média do aluno {boletim.Aluno} é {boletim.Media}");
            Fim();
        }

        private static void XeqBubbleSort()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetSentido();

            if (opcao == 1)
                array = BubbleSort.Ascende(array);
            else
                array = BubbleSort.Descende(array);

            Cabecalho();
            ProgramBase.PrintArray(array);
            Fim();
        }

        private static void XeqSelectionSort()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetSentido();

            if (opcao == 1)
                array = SelectionSort.Ascende(array);
            else
                array = SelectionSort.Descende(array);

            Cabecalho();
            ProgramBase.PrintArray(array);
            Fim();
        }

        private static void XeqInserctionSort()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetSentido();

            if (opcao == 1)
                array = InsectionSort.Ascende(array);
            else
                array = InsectionSort.Descende(array);

            Cabecalho();
            ProgramBase.PrintArray(array);
            Fim();
        }

        private static void XeqPesquisa()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetPesquisa();

            Console.WriteLine();
            Console.WriteLine("Que valor deseja pesquisar?");
            var pesquisar = double.Parse(Console.ReadLine());
            int posicao;

            if (opcao == 1)
                posicao  = Pesquisa.Sequencial(pesquisar, array);
            else
                posicao = Pesquisa.Sequencial(pesquisar, array);

            Cabecalho();
            Console.WriteLine($"{pesquisar} encontra-se na posição {posicao} do vetor não classificado.");
            Fim();
        }

        private static void Cabecalho()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========================================================================");
            Console.WriteLine();
        }

        private static void Fim()
        {
            Console.WriteLine();
            Console.WriteLine("===========================================================================");
            Console.WriteLine();
        }
    }
}

