using System.ComponentModel;
using Tiradentes.DF.Application.Enuns;

namespace Tiradentes.DF.Application.ViewModels.Docsign
{
    public class ErroResponse
    {
        public DocSignErro? Codigo { get; set; }
        public string Descricao { get; set; }

        public ErroResponse(DocSignErro docSignErro)
        {
            Codigo = docSignErro;
            Descricao = ((DescriptionAttribute[])docSignErro.GetType().GetField(docSignErro.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false))[0].Description;
        }
    }
}
