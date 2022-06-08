using Tiradentes.DF.Application.ViewModels.Curso;

namespace Tiradentes.DF.Application.ViewModels.Aluno
{
    public class AlunoViewModel
    {
        public int IDT_ALU { get; set; }
        public string MAT_ALU { get; set; }
        public string NOM_ALU { get; set; }
        public int COD_CURSO { get; set; }
        public int SEQ_TPO_PARC { get; set; }
        public int ANO_INGRESSO { get; set; }
        public int SEM_INGRESSO { get; set; }
        public string TPO_INGRESSO { get; set; }
        public string TPO_ENT_ENEM { get; set; }
        public string CPF_ALU { get; set; }
        public string NACIONALIDADE { get; set; }
        public string END_ALU { get; set; }
        public string BAIRRO_ALU { get; set; }
        public string CID_ALU { get; set; }
        public string UF_ALU { get; set; }
        public string CEP_ALU { get; set; }
        public int IDT_RESP { get; set; }
        public string DAT_NASC { get; set; }

        public CursoViewModel Curso { get; set; }
    }
}