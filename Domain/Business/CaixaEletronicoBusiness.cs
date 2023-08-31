using Domain.Model;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Business
{
    public class CaixaEletronicoBusiness
    {
        private readonly CaixaEletronicoRepository _caixaEletronicoRepository;
        public CaixaEletronicoBusiness()
        {
            _caixaEletronicoRepository = new CaixaEletronicoRepository();
        }
        public CaixaEletronico RealizarSaque(int valorSaque)
        {
           
            CaixaEletronico cx = _caixaEletronicoRepository.ObterNotasDisponiveis()!;
            CaixaEletronico saque = new CaixaEletronico();
            int totalCaixa = 0;

            totalCaixa += cx.NotaDez!.ValorTotal;
            totalCaixa += cx.NotaVinte!.ValorTotal;
            totalCaixa += cx.NotaCinquenta!.ValorTotal;
            totalCaixa += cx.NotaCem!.ValorTotal;
            totalCaixa += cx.NotaDuzentos!.ValorTotal;

            
            if (valorSaque > totalCaixa || (valorSaque % 10 != 0))
            {
                throw new Exception("Não é possível sacar esse valor.");
            }           

            while(valorSaque != 0)
            {
                if (cx.NotaDuzentos.Quantidade > 0 && valorSaque >= cx.NotaDuzentos.Valor)
                {
                    valorSaque -= cx.NotaDuzentos.Valor;
                    cx.NotaDuzentos.Quantidade -= 1;  
                    saque.NotaDuzentos.Quantidade += 1;
                }
                else if (cx.NotaCem.Quantidade > 0 && valorSaque >= cx.NotaCem.Valor)
                {
                    valorSaque -= cx.NotaCem.Valor;
                    cx.NotaCem.Quantidade -= 1;
                    saque.NotaCem.Quantidade += 1;
                }
                else if (cx.NotaCinquenta.Quantidade > 0 && valorSaque >= cx.NotaCinquenta.Valor)
                {
                    valorSaque -= cx.NotaCinquenta.Valor;
                    cx.NotaCinquenta.Quantidade -= 1;
                    saque.NotaCinquenta.Quantidade += 1;
                }
                else if (cx.NotaVinte.Quantidade > 0 && valorSaque >= cx.NotaVinte.Valor)
                {
                    valorSaque -= cx.NotaVinte.Valor;
                    cx.NotaVinte.Quantidade -= 1;
                    saque.NotaVinte.Quantidade += 1;
                }
                else if (cx.NotaDez.Quantidade > 0 && valorSaque >= cx.NotaDez.Valor)
                {
                    valorSaque -= cx.NotaDez.Valor;
                    cx.NotaDez.Quantidade -= 1;
                    saque.NotaDez.Quantidade += 1;
                }
            }

            if(valorSaque == 0)
            {
                _caixaEletronicoRepository.AtualizarCaixaEletronico(cx);

                return saque;               
            } 
            
            return saque;
          
        }
    }
}
