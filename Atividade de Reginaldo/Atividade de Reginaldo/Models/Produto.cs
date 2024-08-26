using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_Reginaldo.Models
{
 public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public Produto(int id, string nome, DateTime dataVencimento)
        {
            Id = id;
            Nome = nome;
            DataVencimento = dataVencimento;
        }
        public bool EstaVencido(DateTime dataAtual)
        {
            return DataVencimento < dataAtual;
        }
    }
}
