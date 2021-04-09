namespace Revisao
{
    public static class Pesquisa
    {
        public static Resultado Sequencial(double pesquisa, double[] sortArray)
        {
            var i = 0;
            var resultado = new Resultado();

            for (i = 0; i < sortArray.Length - 1; i++)
                if (sortArray[i] == pesquisa)
                {
                    resultado.Encontrado = true;
                    break;
                }

            resultado.Posicao = resultado.Posicao + 1;

            return resultado;
        }

        public static Resultado Binaria(double chave, double[] sortArray)
        {
            var array = new CronArray();
            array = InsectionSort.Ascende(sortArray);
            
            var piso = 0;
            var teto = sortArray.Length - 1;
            var resultado = new Resultado();
            resultado.Encontrado = false;

            do
            {
                var meio = (piso + teto) / 2;

                if (sortArray[meio] == chave)
                {
                    resultado.Encontrado = true;
                    resultado.Posicao = meio + 1;

                    return resultado;
                }

                if (chave > sortArray[meio])
                    piso = meio + 1;
                else
                    teto = meio - 1;

            }
            
            while (piso <= teto);

            return resultado;
        }
    }
}
