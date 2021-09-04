using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T> //Interface c/método chamado lista que retorna uma lista de T
    {
        List<T> Lista();

        int ProximoId();

        void Atualiza(int id, T entidade);

        void Exclui(int id);

        void Insere(T entidade);

        T RetornaPorId(int id); //Retorna T como parâmetro


    }
}
