using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Annoyotron.ViewModels
{
    // This shows no references because it's referred to  in the XAML rather than the code.
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<ViewItem> Views { get; } =
            ViewItemFactory.CreateViewItems;

        private ViewItem _selectedView = Views.FirstOrDefault();

        public ViewItem SelectedView
        {
            get => _selectedView;
            set => SetField(ref _selectedView, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // Basically encapsulates the "if value is unchanged do nothing, else
        // set value and post PropertyChanged message" dealio.
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
