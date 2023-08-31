using Domain.Model.Notas;

namespace DesafioGeogin.Models
{
    public class CaixaEletronico
    {
        public CaixaEletronico()
        {
            NotaDuzentos = new NotaDuzentos();
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

    }
}
