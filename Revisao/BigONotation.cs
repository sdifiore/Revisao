using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class BigONotation
    {
        public void Log(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine(numeros[i]);
        }
    }
}
