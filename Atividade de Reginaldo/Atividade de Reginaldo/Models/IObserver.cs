using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_Reginaldo.Models
{
    public interface IObserver
    {
        void Update(Produto produto);
    }
}

