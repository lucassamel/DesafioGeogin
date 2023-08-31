using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Notas
{
    public class NotaCem 
    {
        public NotaCem()
        {
            Quantidade = 0;
            Valor = 100;
            ValorTotal = 0;
        }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public int ValorTotal { get; set; }
    }
}
