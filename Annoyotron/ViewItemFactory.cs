using System;
using Annoyotron.ViewModels;
using Annoyotron.Views;

namespace Annoyotron
{
    public static class ViewItemFactory
    {
        public static ViewItem CreateViewItem(IAuthenticationViewModel authenticationViewModel)
        {
            return authenticationViewModel switch
            {
                CardAuthenticationViewModel => 
                    new ViewItem(new CardAuthView(authenticationViewModel), "Card based signing"),
                SingleUserPinAuthenticationViewModel => 
                    new ViewItem(new SingleUserPinAuthView(authenticationViewModel), "Single-person PIN signing"),
                MultiUserPinAuthenticationViewModel => 
                    new ViewItem(new MultiUserPinAuthView(authenticationViewModel), "Multi-person PIN signing"),
                _ => throw new NotSupportedException("Factory method has no match for this viewmodel.")
            };
        }
    }
}
