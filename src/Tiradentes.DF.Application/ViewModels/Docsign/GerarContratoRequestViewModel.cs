namespace Tiradentes.DF.Application.ViewModels.Docsign
{
    public class GerarContratoRequestViewModel
    {
        public string Inscricao { get; set; }
        public decimal Matricula { get; set; }
        public EnvelopeRequestViewModel Envelope { get; set; }
    }
}
