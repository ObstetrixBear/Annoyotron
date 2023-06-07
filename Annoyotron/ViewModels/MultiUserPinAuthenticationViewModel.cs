using System;

namespace Annoyotron.ViewModels
{
    public class MultiUserPinAuthenticationViewModel : IAuthenticationViewModel
    {
        public bool Authenticated { get; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
