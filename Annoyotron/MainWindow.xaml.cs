using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Annoyotron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // This should go into MainWindowViewModel.cs
        public ObservableCollection<ViewItem> Views { get; } =
            ViewItemFactory.CreateViewItems;

        // This should be kept in MainWindowViewModel.cs, as it is the state we wish to alter.
        private ViewItem _selectedView;

        // This should be handled differently, in some purer type of XAML-based binding deal.
        // Is that even a thing?
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

        // See above: if SelectedView is gone, we cut this
        public event PropertyChangedEventHandler PropertyChanged;

        // See above: if SelectedView is gone, we cut this, and good fecking riddance.
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
