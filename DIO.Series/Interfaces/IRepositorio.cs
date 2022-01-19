using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> List();
         T RetornarPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();// ver
    }
}