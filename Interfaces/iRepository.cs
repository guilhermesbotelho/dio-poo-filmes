using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_poo_filmes.Interfaces
{
    public interface iRepository<T>
    {
        List<T> List();
        T getById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int nextId();
    }
}