namespace Revisao
{
    public static class SelectionSort
    {
        public static double[] Ascende(double[] sortArray)
        {
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

            return sortArray;
        }

        public static double[] Descende(double[] sortArray)
        {
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

            return sortArray;
        }
    }
}
