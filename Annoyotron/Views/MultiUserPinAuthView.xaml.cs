using Annoyotron.ViewModels;
using System.Windows.Controls;

namespace Annoyotron.Views
{
    /// <summary>
    /// Interaction logic for MultiUserPinAuthView.xaml
    /// </summary>
    public partial class MultiUserPinAuthView : UserControl
    {
        private IAuthenticationViewModel _viewModel;

        public MultiUserPinAuthView(IAuthenticationViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
        }
    }
}
