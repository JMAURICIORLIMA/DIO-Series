using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    //Classe SerieRepositorio herda de IRepositorio que herda de Serie
    public class SerieRepositorio : IRepositorio<Serie>
    {
        //variavel Lista<Serie> / Quando instaciada irá instaciar nova lista
        private List<Serie> listaSerie = new List<Serie>(); 
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
