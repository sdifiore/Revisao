namespace Revisao
{
    public class ListaSeq
    {
        private RegSeq _lista;
        private int _maxSize;

        public void CriaLista(int maxSize)
        {
            _maxSize = maxSize;
            _lista = new RegSeq(maxSize);

            _lista.Indice = 0;
        }

        public bool IsVazia()
        {
            if (_lista.Indice == 0)
                return true;

            return false;
        }

        public bool Insere(string valor)
        {
            if (_lista.Indice == _maxSize)
                return false;

            for (int i = 0; i < _maxSize; i++)
                _lista.Lista[i + 1] = _lista.Lista[i];

            _lista.Lista[0] = valor;

            return true;
        }

        public int Tamanho()
        {
            return _lista.Indice;
        }
    }
}
