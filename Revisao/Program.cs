using System;

namespace Revisao
{
    class Program
    {
        static void Main()
        {
            int opcao = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("============================");
                Console.WriteLine("[0] Encerra");
                Console.WriteLine("[1] Números Primos");
                Console.WriteLine("[2] Boletim");
                Console.WriteLine("[3] Novo Boletim");
                Console.WriteLine("[4] Buble Sort");
                Console.WriteLine("[5] Selection Sort");
                Console.WriteLine("[6] Insection Sort");
                Console.WriteLine("[7] Pesquisa");
                Console.WriteLine("[8] Lista Sequencial");
                Console.WriteLine("[9] Lista Encadeada");
                Console.WriteLine("============================");
                Console.ForegroundColor = ConsoleColor.White;

                var ok = false;

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
                    case 8:
                        XeqListaSequencial();
                        break;
                    case 9:
                        XeqListaEncadeada();
                        break;

                    default:
                        break;
                }
            }

            while (opcao > 0);
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

            ProgramBase.Cabecalho();

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

        private static void XeqListaSequencial()
        {
            ProgramBase.Cabecalho();

            Console.WriteLine("De que tamanho deseja a lista: ");
            var tamanho = int.Parse(Console.ReadLine());

            var listaSeq = new ListaSeq();

            listaSeq.CriaLista(tamanho);

            var acao = 0;

            do

            {
                acao = ProgramBase.GetListaSeqOpcao();

                if (acao == 1)
                    XeqInsereSequencial(listaSeq);
                else if (acao == 2)
                    XeqDelLastElementSeq(listaSeq);
                else
                    break;
            }

            while (acao != 3);

            ProgramBase.Fim();
        }

        private static void XeqInsereSequencial(ListaSeq listaSeq)
        {
            var mensagem = "Valor inserido com sucesso";

            Console.WriteLine("Digite o valor: ");
            var valor = Console.ReadLine();

            if (!listaSeq.Insere(valor))
                mensagem = "Erro: Lista cheia";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.Green;

            XeqListListasequencial(listaSeq);
        }

        private static void XeqListListasequencial(ListaSeq listaSeq)
        {
            var lista = listaSeq.ListLista();

            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < listaSeq.Tamanho(); i++)
                Console.WriteLine($"{i}: {lista[i]}");

            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static void XeqDelLastElementSeq(ListaSeq listaSeq)
        {
            listaSeq.DelLast();
            XeqListListasequencial(listaSeq);
        }

        private static void XeqListaEncadeada()
        {
            ProgramBase.Cabecalho();

            Console.WriteLine("De que tamanho deseja a lista: ");
            var tamanho = int.Parse(Console.ReadLine());

            var listChain = new ListChain(tamanho);

            listChain.CriaLista();

            var acao = 0;

            do

            {
                acao = ProgramBase.GetListaSeqOpcao();

                if (acao == 1)
                    XeqInsereEncadeado(listChain);
                else if (acao == 2)
                    XeqDeleteEncadeadoByIndex(listChain);
                else
                    break;
            }

            while (acao != 3);

            ProgramBase.Fim();

        }

        private static void XeqInsereEncadeado(ListChain listChain)
        {
            var mensagem = "Valor inserido com sucesso";

            Console.WriteLine("Digite o valor: ");
            var valor = Console.ReadLine();

            if (!listChain.Insere(valor))
                mensagem = "Erro: Lista cheia";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.Green;

            XeqListListaEncadeado(listChain);
        }

        private static void XeqListListaEncadeado(ListChain listChain)
        {
            var regChain = listChain.ListLista();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Apontador de início: {regChain.PonteiroInicio}");
            Console.WriteLine($"Apontador de disponibilidade: {regChain.PonteiroDisponivel}");
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < regChain.Lista.Length; i++)
            {
                string indice, valor;

                if (regChain.Indice[i] < 0)
                    indice = regChain.Indice[i].ToString();
                else
                    indice = $" {regChain.Indice[i].ToString()}";

                if (regChain.Lista[i] == string.Empty)
                    valor = "-------";
                else
                    valor = regChain.Lista[i];

                Console.WriteLine($"Posição: {i} - Aponta para: {indice} - Valor: {valor}");
            }

            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static void XeqDeleteEncadeadoByIndex(ListChain listChain)
        {
            var valor = 0;
            var parsed = false;

            while (!parsed)
            {
                Console.WriteLine("Digite o índice do valor que deseja eliminar: ");
                parsed = int.TryParse(Console.ReadLine(),out valor);
            }

            listChain.DeleteByIndex(valor);

            XeqListListaEncadeado(listChain);
        }
    }
}
