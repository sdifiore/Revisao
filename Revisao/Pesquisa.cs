using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public static class Pesquisa
    {
        public static int Sequencial(double pesquisa, double[] sortArray)
        {
            var i = 0;

            for (i = 0; i < sortArray.Length - 1; i++)
                if (sortArray[i] == pesquisa)
                    break;

            return i + 1;
        }
    }
}
