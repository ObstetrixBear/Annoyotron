using System.Collections.Generic;
using Annoyotron.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Annoyotron.ViewModels;


namespace Annoyotron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ViewItem> Views { get; } =
            ViewItemFactory.CreateViewItems;

        private ViewItem _selectedView;

        public ViewItem SelectedView
        {
            get => _selectedView;
            set
            {
                if (_selectedView == value)
                {
                    return;
                }
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
