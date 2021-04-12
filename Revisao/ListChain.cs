using System;

namespace Revisao
{
    public class ListChain
    {
        private RegChain _lista;
        private int _maxSize;
        private readonly Random _random = new Random();

        public void CriaLista(int maxSize)
        {
            _maxSize = maxSize;
            _lista = new RegChain(maxSize);

            for (int i = 0; i < _maxSize; i++)
                _lista.Lista[i] = string.Empty;

            _lista.PonteiroInicio = GetRandonFreeAddress(_lista);
            _lista.Indice[_lista.PonteiroInicio] = 0;
        }

        public bool Insere(string valor)
        {
            var tamanho = Tamanho();

            if (tamanho == _maxSize)
                return false;

            var ponteiro = _lista.PonteiroInicio;

            for (int i = 0; i < tamanho; i++)
                ponteiro = _lista.Indice[i];

            var address = GetRandonFreeAddress(_lista);
            _lista.Indice[ponteiro] = address;
            _lista.Lista[address] = valor;

            return true;
        }

        private int GetRandonFreeAddress(RegChain regChain)
        {
            int address;

            do
            {
                address = _random.Next(0, regChain.Lista.Length);

                if (regChain.Lista[address] == string.Empty)
                    break;
            }
            
            while (true);

            return address;
        }

        private int Tamanho()
        {
            var contador = 0;

            for (int i = 0; i < _maxSize; i++)
                if (_lista.Lista[i] != string.Empty)
                    contador++;

            return contador;
        }

        public string[] ListLista()
        {
            var resultado = new string[_maxSize];

            for (int i = 0; i < _maxSize; i++)
                resultado[i] = _lista.Lista[i];

            return resultado;
        }
    }
}
