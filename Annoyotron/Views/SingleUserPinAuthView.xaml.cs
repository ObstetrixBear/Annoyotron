using Annoyotron.ViewModels;
using System.Windows.Controls;

namespace Annoyotron.Views
{
    /// <summary>
    /// Interaction logic for SingleUserPinAuthView.xaml
    /// </summary>
    public partial class SingleUserPinAuthView : UserControl
    {
        private IAuthenticationViewModel _viewModel;

        public SingleUserPinAuthView(IAuthenticationViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
        }
    }
}
