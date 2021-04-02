using System.Collections.Generic;

namespace Revisao
{
    public class BoletimEscolar
    {
        public string Aluno { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }

        private float media;

        public float Media
        {
            get { return (Nota1 + Nota2 + Nota3) / 3; }
        }

    }
}
