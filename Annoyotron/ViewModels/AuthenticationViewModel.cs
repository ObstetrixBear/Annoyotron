using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annoyotron.ViewModels
{

    public abstract class AuthenticationViewModel
    {
        public bool Authenticated { get; }

        public abstract bool Authenticate();
    }
}
