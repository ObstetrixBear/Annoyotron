using System.Windows.Controls;
using Annoyotron.ViewModels;

namespace Annoyotron.Views
{
    /// <summary>
    /// Interaction logic for CardAuthView.xaml
    /// </summary>
    public partial class CardAuthView : UserControl
    {
        private IAuthenticationViewModel _viewModel;

        public CardAuthView(IAuthenticationViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
        }
    }
}
