namespace Tiradentes.DF.Application.ViewModels.Docsign
{
    public class EnvelopeRequestViewModel
    {        
        public string templateId { get; set; }
        public ReceiverViewModel receiver { get; set; }
        public DocumentDataViewModel documentData { get; set; }
    }
}
