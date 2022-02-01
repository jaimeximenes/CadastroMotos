
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroMotos
{
    public class Moto : EntidadeBase
    {
        public Estilo estilo { get; set; }
        public string Nome { get; set; }
        public int Cilindrada { get; set; }
        public string Descricao { get; set; }
        public int AnoFabricacao { get; set; }
        private bool Excluido { get; set; }
        public Moto(int id, Estilo estilo, string nome, string descricao, int cilindrada, int anoFabricacao)
        {
            this.estilo = estilo;
            this.Nome = nome;
            this.Cilindrada = cilindrada;
            this.Descricao = descricao;
            this.AnoFabricacao = anoFabricacao;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Estilo = " + this.estilo + Environment.NewLine;
            retorno += "Nome= " + this.Nome + Environment.NewLine;
            retorno += "Cilindrada = " + this.Cilindrada + Environment.NewLine;
            retorno += "Descrição = " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Fabricação = " + this.AnoFabricacao + Environment.NewLine;
            retorno += "Excluido" + this.Excluido;

            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Delete()
        {
            this.Excluido = true;
        }

    }
}
