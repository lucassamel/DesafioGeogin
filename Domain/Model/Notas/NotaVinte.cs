using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Notas
{
    public class NotaVinte
    {
        public NotaVinte()
        {
            Valor = 10;
        }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public int ValorTotal { get { return this.Quantidade * this.Valor; } }
    }
}
