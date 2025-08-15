using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;




namespace LojaApp.ViewModels
{
    public class SidebarButtonViewModel : INotifyPropertyChanged
    {
        private string _title;
        private string _icon;
        private bool _isSelected;
        private ICommand _command;

        public string Title
        {
            get => _title;
            set { if (_title != value) { _title = value; OnPropertyChanged(); } }
        }

        public string Icon
        {
            get => _icon;
            set { if (_icon != value) { _icon = value; OnPropertyChanged(); } }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set { if (_isSelected != value) { _isSelected = value; OnPropertyChanged(); } }
        }

        public ICommand Command
        {
            get => _command;
            set { if (_command != value) { _command = value; OnPropertyChanged(); } }
        }

        // ✅ Construtor com DOIS argumentos: título e ícone
        public SidebarButtonViewModel(string title, string icon)
        {
            Title = title;
            Icon = icon;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
