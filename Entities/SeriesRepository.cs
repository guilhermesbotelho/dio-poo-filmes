using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_poo_filmes.Interfaces;

namespace dio_poo_filmes
{
    public class SeriesRepository : iRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Delete(int id)
        {
            listSerie[id].Delet();
        }

        public Serie getById(int id)
        {
            return listSerie[id];
        }

        public void Insert(Serie entity)
        {
            listSerie.Add(entity);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int nextId()
        {
            return listSerie.Count;
        }

        public void Update(int id, Serie entity)
        {
            listSerie[id] = entity;
        }
    }
}