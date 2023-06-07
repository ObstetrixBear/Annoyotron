using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Annoyotron.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged

    {
        public static ObservableCollection<ViewItem> Views { get; } =
            ViewItemFactory.CreateViewItems;

        // This should be kept in MainWindowViewModel.cs, as it is the actual state we want to toggle.
        private ViewItem _selectedView = Views.FirstOrDefault();

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

                SetField(ref _selectedView, value);
                _selectedView = value;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
