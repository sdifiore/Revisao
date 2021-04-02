
namespace Revisao
{
    public static class InsectionSort
    {
        public static double[] Ascende(double[] sortArray)
        {
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

            return sortArray;
        }

        public static double[] Descende(double[] sortArray)
        {
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

            return sortArray;
        }
    }
}
