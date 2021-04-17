using System.Collections.Generic;

namespace Revisao
{
    public class RegChain
    {
        public string[] Lista { get; set; }

        public int[] Indice { get; set; }

        public int PonteiroInicio { get; set; }

        public int PonteiroDisponivel { get; set; }

        public RegChain(int maxSize)
        {
            Lista = new string[maxSize];
            Indice = new int[maxSize];
            PonteiroDisponivel = -1;

            for (int i = 0; i < maxSize; i++)
            {
                Lista[i] = string.Empty;
                Indice[i] = -2;
            }
        }
    }
}