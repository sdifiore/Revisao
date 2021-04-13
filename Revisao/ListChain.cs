using System;

namespace Revisao
{
    public class ListChain
    {
        private RegChain _lista;
        private int _maxSize;
        private bool _naoIniciado;
        private readonly Random _random = new Random();

        public void CriaLista(int maxSize)
        {
            _maxSize = maxSize;
            _lista = new RegChain(maxSize);

            for (int i = 0; i < _maxSize; i++)
                _lista.Lista[i] = string.Empty;

            _lista.PonteiroInicio = GetRandonFreeAddress(_lista);
            _lista.Indice[_lista.PonteiroInicio] = -1;
            _lista.PonteiroDisponivel = -1;
            _naoIniciado = true;
        }

        public bool Insere(string valor)
        {
            if (Tamanho() == _maxSize)
                return false;

            int anterior;

            if (_naoIniciado)
            {
                _naoIniciado = false;
                anterior = _lista.PonteiroInicio;
                _lista.Lista[_lista.PonteiroInicio] = valor;
            }

            else
            {
                anterior = _lista.PonteiroInicio;
                var ponteiro = _lista.PonteiroInicio;

                while (_lista.Indice[ponteiro] != -1)
                {
                    anterior = ponteiro;
                    ponteiro = _lista.Indice[ponteiro];
                }

                anterior = ponteiro;
                ponteiro = _lista.Indice[ponteiro];

                var address = GetRandonFreeAddress(_lista);
                _lista.Lista[address] = valor;
                _lista.Indice[address] = -1;
                _lista.Indice[anterior] = address;

            }

            return true;
        }

        public void DeleteByIndex(int indice)
        {
            _lista.Indice[QuemAponta(indice)] = _lista.Indice[indice];
            _lista.PonteiroDisponivel = indice;
            _lista.Indice[indice] = 0;
        }

        private int QuemAponta(int paraMim)
        {
            var anterior = paraMim;
            var pesquisa = _lista.PonteiroInicio;

            while (pesquisa != paraMim)
            {
                anterior = pesquisa;
                pesquisa = _lista.Indice[pesquisa];
            }

            return anterior;
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

        public RegChain ListLista()
        {
            return _lista;
        }
    }
}
