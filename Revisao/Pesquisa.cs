namespace Revisao
{
    public static class Pesquisa
    {
        public static int Sequencial(double pesquisa, double[] sortArray)
        {
            var i = 0;
            var encontrado = false;

            for (i = 0; i < sortArray.Length - 1; i++)
                if (sortArray[i] == pesquisa)
                {
                    encontrado = true;
                    break;
                }


            if (!encontrado)
                i = int.MaxValue;

            return i + 1;
        }

        public static int Binaria(double pesquisa, double[] sortArray)
        {
            var sentido = ProgramBase.GetSentido();

            if (sentido == 1)
                sortArray = InsectionSort.Ascende(sortArray);
            else
                sortArray = InsectionSort.Descende(sortArray);

            { }

            var posicao = Sequencial(pesquisa, sortArray);

            return posicao;
        }
    }
}
