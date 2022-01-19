using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaPessoa = new List<Series>();
        public void Atualizar(int id, Series pessoa)
        {
            listaPessoa[id] = pessoa;
        }

        public void Exclui(int id)
        {
            listaPessoa[id].Excluir();
            //implemento envio email
        }

        public void Insere(Series pessoa)
        {
            listaPessoa.Add(pessoa);
        }

        public List<Series> List()
        {
            return listaPessoa;
        }

        public int ProximoId()
        {
            return listaPessoa.Count;
        }

        public Series RetornarPorId(int id)
        {
            return listaPessoa[id];
        }

        
    }
}