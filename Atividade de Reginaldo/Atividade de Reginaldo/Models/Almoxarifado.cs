using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_Reginaldo.Models
{
    public class Almoxarifado
    {
        private List<IObserver> _observers = new List<IObserver>();
        private List<Produto> _produtos = new List<Produto>();

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Produto produto)
        {
            foreach (var observer in _observers)
            {
                observer.Update(produto);
            }
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void VerificarProdutosVencidos(DateTime dataAtual)
        {
            foreach (var produto in _produtos)
            {
                if (produto.EstaVencido(dataAtual))
                {
                    Notify(produto);
                }
            }
        }
    }
}
