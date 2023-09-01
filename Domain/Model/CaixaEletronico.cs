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
        public CaixaEletronico()
        {
            NotaDuzentos =  new NotaDuzentos();
            NotaCem = new NotaCem();
            NotaCinquenta = new NotaCinquenta();
            NotaVinte = new NotaVinte();
            NotaDez = new NotaDez();
        }

        public NotaDez NotaDez { get; set; }
        public NotaVinte NotaVinte { get; set; }
        public NotaCinquenta NotaCinquenta { get; set; }
        public NotaCem NotaCem { get; set; }
        public NotaDuzentos NotaDuzentos { get; set; }
        public int TotalCaixa
        {
            get
            {
                return this.NotaDez.ValorTotal +
                    this.NotaVinte.ValorTotal +
                    this.NotaCinquenta.ValorTotal +
                    this.NotaCem.ValorTotal +
                    this.NotaDuzentos.ValorTotal;
            }
        }

    }
}
