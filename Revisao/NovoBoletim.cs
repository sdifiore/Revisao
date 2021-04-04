using System.Collections.Generic;

namespace Revisao
{
    public class NovoBoletim
    {
        public string Aluno { get; set; }
        public List<float> Notas { get; set; }

        private float media;

        public float Media
        {
            get
            {
                media = 0;

                foreach (var nota in Notas)
                    media += nota;

                media = media / Notas.Count;

                return media;
            }

            set { media = value; }
        }

        public NovoBoletim()
        {
            Notas = new List<float>();
        }
    }
}