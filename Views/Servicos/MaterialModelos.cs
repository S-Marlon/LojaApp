using System.Collections.ObjectModel;
using System.ComponentModel;
using LojaApp.Views.Servicos;

public class MaterialModelo : INotifyPropertyChanged
{
    public ObservableCollection<ServicoModelo> Material { get; set; }

    public MaterialModelo()
    {
        Material = new ObservableCollection<ServicoModelo>
        {
          new ServicoModelo { Produto = "Mangueira", Quantidade = "0.7", ValorUnitario = "12", ValorTotal = "23"},
          new ServicoModelo { Produto = "Jic 37", Quantidade = "2", ValorUnitario = "6", ValorTotal = "43"},
          new ServicoModelo { Produto = "s ", Quantidade = "2", ValorUnitario = "3", ValorTotal = "44"},
          new ServicoModelo { Produto = "sad ", Quantidade = "2", ValorUnitario = "3", ValorTotal = "44"}

        };

    }

    public event PropertyChangedEventHandler PropertyChanged;
}
