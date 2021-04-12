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

            for (int i = 0; i < _maxSize; i++)
                _lista.Lista[i] = string.Empty;

            _lista.Indice = 0;
        }

        public bool Insere(string valor)
        {
            if (_lista.Indice == _maxSize)
                return false;

            for (int i = _maxSize - 2; i > -1; i--)
                _lista.Lista[i + 1] = _lista.Lista[i];
            
            _lista.Lista[0] = valor;
            _lista.Indice++;

            return true;
        }

        public void DelLast()
        {
            if (_lista.Indice == 0)
                return;

            for (int i = 0; i < _maxSize -1; i++)
                _lista.Lista[i] = _lista.Lista[i + 1];

            _lista.Indice--;
        }

        public int Tamanho()
        {
            return _lista.Indice;
        }

        public string[] ListLista()
        {
            var resultado = new string[_lista.Indice];

            for (int i = 0; i < _lista.Indice; i++)
                resultado[i] = _lista.Lista[i];

            return resultado;
        }
    }
}
