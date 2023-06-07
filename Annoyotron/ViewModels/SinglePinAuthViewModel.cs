using System;

namespace Annoyotron.ViewModels
{
    public class SinglePinAuthViewModel : IAuthenticationViewModel
    {
        public bool Authenticated { get; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
