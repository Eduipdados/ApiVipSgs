using Tiradentes.DF.Application.Enuns;

namespace Tiradentes.DF.Application.ViewModels.Docsign
{
    public class EnvelopeStatusViewModel
    {
          public string envelopeId { get; set; }
          public string envelopeStatus { get; set; }
          public ErroResponse Erro { get; set; }
    }
}
