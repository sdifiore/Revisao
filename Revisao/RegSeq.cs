namespace Revisao
{
    public class RegSeq
    {
        public string[] Lista { get; set; }

        public int Indice { get; set; }

        public RegSeq(int maxSize)
        {
            Lista = new string[maxSize];
        }
    }
}
