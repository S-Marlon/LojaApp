using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaApp.Views.Servicos
{
    public class ServicoModel
    {
        public string NomeCliente { get; set; }
        public string TipoServico { get; set; }
        public string Data { get; set; }
        public string Garantia { get; set; }
        public string Codigoservico { get; set; }

    }

    public class ServicoModelo
    {
        public string Produto { get; set; }
        public string Quantidade  { get; set; }
        public string ValorUnitario { get; set; }
        public string ValorTotal { get; set; }

    }
}
