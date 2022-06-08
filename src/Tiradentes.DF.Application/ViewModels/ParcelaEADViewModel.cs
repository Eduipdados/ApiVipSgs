using System;

namespace Tiradentes.DF.Application.ViewModels
{
    public class ParcelaEadViewModel
    {
        public int IDT_CURSO { get; set; }
        public string TURMA { get; set; }
        public int COD_CURR_CURSO { get; set; }
        public int PARCELA { get; set; }
        public decimal VALOR { get; set; }
        public int PERIODO { get; set; }
        public DateTime DAT_VENC { get; set; }
    }
}