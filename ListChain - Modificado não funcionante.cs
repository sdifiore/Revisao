using System;
using System.Net;

namespace Revisao
{
    public class ListChain
    {
        private int _maxSize;
        private RegChain _lista;
        private readonly Random _random = new Random();

        public void CriaLista(int maxSize)
        {
            _maxSize = maxSize;
            _lista = new RegChain(maxSize);

            for (int i = 0; i < _maxSize; i++)
            {
                _lista.Lista[i] = string.Empty;
                _lista.Indice[i] = -2;
            }

            //_lista.PonteiroInicio = GetNextFreeAddress();
            //_lista.Indice[_lista.PonteiroInicio] = -1;
        }

        public bool Insere(string valor)
        {
            if (Tamanho() == _maxSize)
                return false;

            var address = GetNextFreeAddress();

            if (_lista.PonteiroInicio == -1)
            {
                _lista.Lista[address] = valor;
                _lista.Indice[address] = -1;
            }

            else
            {
                var anterior = -1;
                var ponteiro = _lista.PonteiroInicio;

                while (_lista.Indice[ponteiro] != -1)
                {
                    anterior = ponteiro;
                    ponteiro = _lista.Indice[ponteiro];
                }

                anterior = ponteiro;
                ponteiro = _lista.Indice[ponteiro];

                _lista.Lista[address] = valor;
                _lista.Indice[address] = -1;
                _lista.Indice[anterior] = address;

            }

            return true;
        }

        public void DeleteByIndex(int indice)
        {
            if (indice == _lista.PonteiroInicio)
                _lista.PonteiroInicio = _lista.Indice[indice];
            else
                _lista.Indice[QuemAponta(indice)] = _lista.Indice[indice];

            _lista.Indice[indice] = -2;
            _lista.Lista[indice] = string.Empty;
            InserePonteiroDisponivel(indice);
            FirstPonteiroDisponivel();
        }

        public RegChain ListLista()
        {
            return _lista;
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

        private int GetNextFreeAddress()
        {
            int address;
            var ponteiro = FirstPonteiroDisponivel();

            if (ponteiro > -1)
            {
                address = _lista.PonteiroDisponivel[ponteiro];
                _lista.PonteiroDisponivel[ponteiro] = -1;
            }
                
            else
            {
                do
                {
                    address = _random.Next(0, _lista.Lista.Length);

                    if (_lista.Lista[address] == string.Empty)
                        break;
                }

                while (true);
            }

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

        private int FirstPonteiroDisponivel()
        {
            var i = _maxSize - 1;
            var endereço = -1;

            while (i > -1)
            {
                if (_lista.PonteiroDisponivel[i] > -1)
                {
                    endereço = i;
                     break;
                }

                i--;
            }

            return endereço;
        }

        private void InserePonteiroDisponivel(int endereço)
        {
            var pontoInsercao = FirstPonteiroDisponivel() + 1;
            _lista.PonteiroDisponivel[pontoInsercao] = endereço;
        }
    }
}