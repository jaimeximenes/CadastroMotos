using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroMotos
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T ReturnById(int id);
        void Insert(T entidade);
        void Delete(int Id);
        void Update(int Id, T entidade);
        int NextId();

    }
}
