namespace Revisao
{
    public static class BubbleSort
    {
        public static double[] Ascende(double[] sortArray)
        {
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

            return sortArray;
        }

        public static double[] Descende(double[] sortArray)
        {
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

            return sortArray;
        }
    }
}
