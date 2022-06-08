namespace Tiradentes.DF.Application.ViewModels
{
    public class DescontoViewModel
    {
        public int IDT_ALU { get; set; }
        public int ANO { get; set; }
        public int SEMESTRE { get; set; }
        public int PARCELA { get; set; }
        public string TPO_DESCONTO { get; set; }
        public decimal VAL_DESCONTO { get; set; }
        public string PARC_GERADA { get; set; }
    }
}