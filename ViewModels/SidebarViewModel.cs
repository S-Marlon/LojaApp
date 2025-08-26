using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LojaApp.ViewModels;

namespace LojaApp.ViewModels
{
    public class SidebarViewModel
    {
        public ICommand SelectCommand { get; }
        public ObservableCollection<SidebarButtonViewModel> Buttons { get; } = new();

        public SidebarViewModel()
        {
            // Instancia SÓ com (title, icon)
            ////var inicio = new SidebarButtonViewModel("Início", "dotnet_bot.png");
            ////var pdv = new SidebarButtonViewModel("PDV", "dotnet_bot.png");
            ////var servicos = new SidebarButtonViewModel("Serviços", "dotnet_bot.png");
            ////var produtos = new SidebarButtonViewModel("Produtos", "dotnet_bot.png");
            ////var relatorios = new SidebarButtonViewModel("Relatórios", "dotnet_bot.png");

            //// Depois atribui o Command (sem CommunityToolkit)
            //inicio.Command = new Command(() => SelectAndNavigate(inicio, "//Dashboard"));
            //pdv.Command = new Command(() => SelectAndNavigate(pdv, "//PdvPage"));
            //servicos.Command = new Command(() => SelectAndNavigate(servicos, "servico"));
            //produtos.Command = new Command(() => SelectAndNavigate(produtos, "CadastrarServico"));
            //relatorios.Command = new Command(() => SelectAndNavigate(relatorios, "//Relatorios"));

            //Buttons.Add(inicio);
            //Buttons.Add(pdv);
            //Buttons.Add(servicos);
            //Buttons.Add(produtos);
            //Buttons.Add(relatorios);

            //// Seleciona inicialmente
            //SetSelected(inicio);
        }

        private void SelectAndNavigate(SidebarButtonViewModel item, string route)
        {
            SetSelected(item);
            // Use Shell se estiver usando rotas; adapte se estiver trocando ContentView manualmente
            Shell.Current?.GoToAsync(route);
        }

        private void SetSelected(SidebarButtonViewModel selected)
        {
            foreach (var b in Buttons) b.IsSelected = false;
            selected.IsSelected = true;
        }

        public List<SidebarButtonViewModel> SidebarItems { get; set; }
    }
}
