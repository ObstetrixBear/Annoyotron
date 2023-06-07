using System;

namespace Annoyotron.ViewModels
{
    public class MultiPinAuthViewModel : IAuthenticationViewModel
    {
        public bool Authenticated { get; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
