using System;

namespace Tiradentes.DF.Application.ViewModels
{
    public class ParcelaViewModel
    {
        public int SEQUENCIAL { get; set; }
        public int ANO_VDP { get; set; }
        public int SEM_VDP { get; set; }
        public int PARCELA { get; set; }
        public decimal VAL_PARCELA { get; set; }
        public DateTime DAT_VENC { get; set; }
    }
}