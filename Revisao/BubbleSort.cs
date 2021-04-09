using System;

namespace Revisao
{
    public static class BubbleSort
    {
        public static CronArray Ascende(double[] sortArray)
        {
            var startTime = DateTime.Now;
            var dimensao = sortArray.Length;

            for (int i = 1; i < dimensao; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sortArray[j] > sortArray[i])
                    {
                        var calice = sortArray[j];
                        sortArray[j] = sortArray[i];
                        sortArray[i] = calice;
                    }
                }
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
                for (int j = 0; j < i; j++)
                {
                    if (sortArray[j] < sortArray[i])
                    {
                        var calice = sortArray[j];
                        sortArray[j] = sortArray[i];
                        sortArray[i] = calice;
                    }
                }
            }

            var retorno = new CronArray { ArrayValues = sortArray, Duracao = DateTime.Now - startTime };

            return retorno;
        }
    }
}
