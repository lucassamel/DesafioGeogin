using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Notas
{
    public class NotaDuzentos
    {
        public NotaDuzentos()
        {
            Valor = 200;
        }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public int ValorTotal { get { return this.Quantidade * this.Valor; } }
    }
}

