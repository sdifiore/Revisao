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
        }
    }
}
