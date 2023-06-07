using System;

namespace Annoyotron.ViewModels
{
    internal class CardAuthViewModel : IAuthenticationViewModel
    {
        public bool Authenticated { get; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
