using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroMotos
{
    public class MotoRepositorio : IRepositorio<Moto>
    {
        private List<Moto> listaMotos = new List<Moto>();
        public void Atualiza(int id, Moto entidade)
        {
            listaMotos[id] = entidade;
        }
        public void Delete(int id)
        {
            listaMotos[id].Delete();

        }

        public void Insert(Moto entidade)
        {
            listaMotos.Add(entidade);
        }

        public List<Moto> Lista()
        {
            return listaMotos;
        }

        public int NextId()
        {
            return listaMotos.Count;
        }

        public Moto ReturnById(int id)
        {
            return listaMotos[id];
        }

        public void Update(int id, Moto entidade)
        {
            listaMotos[id] = entidade;

        }
    }
}
