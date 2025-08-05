using System.Collections.ObjectModel;
using System.ComponentModel;
using LojaApp.Views.Servicos;

public class ServicoViewModel : INotifyPropertyChanged
{
    public ObservableCollection<ServicoModel> Servicos { get; set; }

    public ServicoViewModel()
    {
        Servicos = new ObservableCollection<ServicoModel>
        {
            new ServicoModel { NomeCliente = "João Silva", TipoServico = "Instalação de Bomba", Data = "25/07/2025", Garantia = "na garantia", Codigoservico = "34567"},
            new ServicoModel { NomeCliente = "Maria Oliveira", TipoServico = "Limpeza de Poço", Data = "23/07/2025", Garantia = "na garantia", Codigoservico = "34545667" },
            new ServicoModel { NomeCliente = "Pedro Santos", TipoServico = "Reparo Elétrico", Data = "20/07/2025", Garantia = "Fora da garantia", Codigoservico = "3457"  },
        };

    }

    public event PropertyChangedEventHandler PropertyChanged;
}
