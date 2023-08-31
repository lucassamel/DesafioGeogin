using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Notas
{
    public class NotaCinquenta
    {
        public NotaCinquenta()
        {
            Quantidade = 0;
            Valor = 50;
            ValorTotal = 0;
        }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public int ValorTotal { get; set; }
    }
}
