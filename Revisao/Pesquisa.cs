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

        public static int Binaria(double chave, double[] sortArray)
        {
            sortArray = InsectionSort.Ascende(sortArray);
            
            var piso = 0;
            var numElementos = sortArray.Length;
            var teto = numElementos - 1;

            do
            {
                var meio = (piso + teto) / 2;

                if (sortArray[meio] == chave)
                    return meio + 1;

                if (chave > sortArray[meio])
                    piso = meio + 1;
                else
                    teto = meio - 1;

            } while (piso <= teto);

            return int.MinValue;
        }
    }
}
