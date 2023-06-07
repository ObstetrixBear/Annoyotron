using System;

namespace Annoyotron.ViewModels
{
    internal class CardAuthenticationViewModel : IAuthenticationViewModel
    {
        public bool Authenticated { get; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
