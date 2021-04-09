using System;

namespace Revisao
{
    public static class SelectionSort
    {
        public static CronArray Ascende(double[] sortArray)
        {
            var startTime = DateTime.Now;
            var dimensao = sortArray.Length;

            for (int i = dimensao - 1; i > 0; i--)
            {
                var maiorIndex = 0;

                for (int j = 1; j < i + 1; j++)
                {
                    if (sortArray[j] > sortArray[maiorIndex])
                        maiorIndex = j;
                }

                var calice = sortArray[i];
                sortArray[i] = sortArray[maiorIndex];
                sortArray[maiorIndex] = calice;
            }

            var retorno = new CronArray { ArrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }

        public static CronArray Descende(double[] sortArray)
        {
            var startTime = DateTime.Now;
            var dimensao = sortArray.Length;

            for (int i = dimensao - 1; i > 0; i--)
            {
                var maiorIndex = 0;

                for (int j = 1; j < i + 1; j++)
                {
                    if (sortArray[j] < sortArray[maiorIndex])
                        maiorIndex = j;
                }

                var calice = sortArray[i];
                sortArray[i] = sortArray[maiorIndex];
                sortArray[maiorIndex] = calice;
            }

            var retorno = new CronArray { ArrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }
    }
}
