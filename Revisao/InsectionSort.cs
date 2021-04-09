
using System;

namespace Revisao
{
    public static class InsectionSort
    {
        public static CronArray Ascende(double[] sortArray)
        {
            var startTime = DateTime.Now;
            var dimensao = sortArray.Length;

            for (int i = 1; i < dimensao; i++)
            {
                var chave = sortArray[i];
                var j = i - 1;

                while(j >= 0 && sortArray[j] > chave)
                {
                    sortArray[j + 1] = sortArray[j];
                    j--;
                }

                sortArray[j + 1] = chave;
            }

            var retorno = new CronArray { ArrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }

        public static CronArray Descende(double[] sortArray)
        {
            var startTime = DateTime.Now;
            var dimensao = sortArray.Length;

            for (int i = 1; i < dimensao; i++)
            {
                var chave = sortArray[i];
                var j = i - 1;

                while (j >= 0 && sortArray[j] < chave)
                {
                    sortArray[j + 1] = sortArray[j];
                    j--;
                }

                sortArray[j + 1] = chave;
            }

            var retorno = new CronArray { ArrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }
    }
}
