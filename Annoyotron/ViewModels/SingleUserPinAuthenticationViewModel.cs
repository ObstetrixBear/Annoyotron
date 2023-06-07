using System;

namespace Annoyotron.ViewModels
{
    public class SingleUserPinAuthenticationViewModel : IAuthenticationViewModel
    {
        public bool Authenticated { get; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
