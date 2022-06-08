namespace Tiradentes.DF.Application.ViewModels.Curso
{
    public class CursoViewModel
    {
        public int COD_CURSO { get; set; }
        public string NOM_CURSO { get; set; }

        public CursoCampusViewModel CursoCampus { get; set; }
    }
}