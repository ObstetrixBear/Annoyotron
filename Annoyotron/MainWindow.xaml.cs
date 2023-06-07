using Annoyotron.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Annoyotron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ViewItem
        {
            public ViewItem(UserControl view, string name)
            {
                View = view;
                Name = name;
            }

            public UserControl View { get; set; }

            public string Name { get; }
        }

        public ObservableCollection<ViewItem> Views { get; } = new()
        {
            new ViewItem(new CardAuthView(), "Card based signing"),
            new ViewItem(new SingleUserPinAuthView(), "Single-person PIN signing"),
            new ViewItem(new MultiUserPinAuthView(), "Multi-person PIN signing")
        };

        private ViewItem _selectedView;

        public ViewItem SelectedView
        {
            get => _selectedView;
            set
            {
                if (_selectedView == value) return;
                _selectedView = value;
                ContentControl.Content = _selectedView.View;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public MainWindow()
        {
            InitializeComponent();

            // This should all be handled in XAML.
            AuthenticationMethodSelector.SelectedIndex = 0;
            SelectedView = Views[0]; // Set the initial selected view
        }
    }
}
