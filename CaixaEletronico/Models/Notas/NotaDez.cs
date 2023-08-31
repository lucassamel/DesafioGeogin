using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Notas
{
    public class NotaDez
    {
        public NotaDez()
        {
            Quantidade = 0;
            Valor = 10;
            ValorTotal = 0;
        }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public int ValorTotal { get; set; }
    }
}
