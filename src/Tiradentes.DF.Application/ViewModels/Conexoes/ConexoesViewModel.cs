using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiradentes.DF.Application.ViewModels.Conexoes
{
    public class ConexoesViewModel
    {
        public string Id { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Instituicao { get; set; }
    }
}
