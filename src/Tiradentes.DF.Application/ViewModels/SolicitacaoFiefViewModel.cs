using Tiradentes.DF.Domain.Models;

namespace Tiradentes.DF.Application.ViewModels
{
    public class SolicitacaoFiefViewModel
    {
        public int ID_SOLICITACAO { get; set; }
        public int IDT_ALU { get; set; }
        public virtual BeneficioFief BeneficioFief { get; set; }
    }
}