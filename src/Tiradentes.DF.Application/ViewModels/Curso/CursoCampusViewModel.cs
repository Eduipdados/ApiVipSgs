using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiradentes.DF.Application.ViewModels.Curso
{
    public class CursoCampusViewModel
    {
        public int COD_CURSO { get; set; }
        public int IDT_CAMPUS { get; set; }
        public string TPO_USO { get; set; }

        public CampusViewModel Campus { get; set; }
    }
}
