using Domain.Model.Notas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class CaixaEletronico
    {
        //public List<Nota> Notas { get; set; }

        public NotaDez? NotaDez { get; set; }
        public NotaVinte? NotaVinte { get; set; }
        public NotaCinquenta? NotaCinquenta { get; set; }
        public NotaCem? NotaCem { get; set; }
        public NotaDuzentos? NotaDuzentos { get; set; }

    }
}
