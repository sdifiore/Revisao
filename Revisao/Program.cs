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
                Console.WriteLine("===========================");
                Console.WriteLine("[1] É Primo");
                Console.WriteLine("[2] Boletim");
                Console.WriteLine("[3] Novo Boletim");
                Console.WriteLine("[4] Buble Sort");
                Console.WriteLine("[5] Selection Sort");
                Console.WriteLine("[6] Insection Sort");
                Console.WriteLine("[7] Pesquisa");
                Console.WriteLine("===========================");
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
            ProgramBase.Cabecalho();
            Console.WriteLine("Até que número deseja pesquisar?");
            var teto = int.Parse(Console.ReadLine());
            
            for (int i = 2; i < teto; i++)
            {
                if (Numero.IsPrime(i))
                    Console.WriteLine(i);
            }

            ProgramBase.Fim();
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

            ProgramBase.Cabecalho();
            Console.WriteLine($"A média do aluno {boletim.Aluno} é {boletim.Media}");
            ProgramBase.Fim();
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

            ProgramBase.Cabecalho();
            Console.WriteLine($"A média do aluno {boletim.Aluno} é {boletim.Media}");
            ProgramBase.Fim();
        }

        private static void XeqBubbleSort()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetSentido();
            var resultado = new CronArray();

            if (opcao == 1)
                resultado = BubbleSort.Ascende(array);
            else
                resultado = BubbleSort.Descende(array);

            ProgramBase.Cabecalho();
            ProgramBase.PrintArray(resultado);
            ProgramBase.Fim();
        }

        private static void XeqSelectionSort()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetSentido();
            var resultado = new CronArray();

            if (opcao == 1)
                resultado = SelectionSort.Ascende(array);
            else
                resultado = SelectionSort.Descende(array);

            ProgramBase.Cabecalho();
            ProgramBase.PrintArray(resultado);
            ProgramBase.Fim();
        }

        private static void XeqInserctionSort()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetSentido();
            var resultado = new CronArray();

            if (opcao == 1)
                resultado = InsectionSort.Ascende(array);
            else
                resultado = InsectionSort.Descende(array);

            ProgramBase.Cabecalho();
            ProgramBase.PrintArray(resultado);
            ProgramBase.Fim();
        }

        private static void XeqPesquisa()
        {

            var dimensao = ProgramBase.GetDimension();
            var array = ProgramBase.GetArray(dimensao);
            var opcao = ProgramBase.GetPesquisa();

            Console.WriteLine();
            Console.WriteLine("Que valor deseja pesquisar?");
            var pesquisar = double.Parse(Console.ReadLine());
            var resultado = new Resultado();
            string fim = "\b";

            if (opcao == 1)
            {
                resultado = Pesquisa.Sequencial(pesquisar, array);
                fim = "não";
            }

            else
                resultado = Pesquisa.Binaria(pesquisar, array);

            ProgramBase.Cabecalho();

            if( !resultado.Encontrado)
                Console.WriteLine("O valor não existe no vetor fornecido");
            else
                Console.WriteLine($"{pesquisar} encontra-se na posição {resultado.Posicao} do vetor {fim} classificado.");
            
            ProgramBase.Fim();
        }
    }
}
