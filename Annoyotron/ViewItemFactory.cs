using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Annoyotron.ViewModels;
using Annoyotron.Views;

namespace Annoyotron
{
    public static class ViewItemFactory
    {
        public static ViewItem CreateViewItem(IAuthenticationViewModel authenticationViewModel) =>
            authenticationViewModel switch
            {
                CardAuthViewModel => 
                    new ViewItem(new CardAuthView(authenticationViewModel), "Card based signing"),
                SinglePinAuthViewModel => 
                    new ViewItem(new SingleUserPinAuthView(authenticationViewModel), "Single-person PIN signing"),
                MultiPinAuthViewModel => 
                    new ViewItem(new MultiUserPinAuthView(authenticationViewModel), "Multi-person PIN signing"),
                _ => throw new NotSupportedException("Factory method has no match for this viewmodel.")
            };

        public static ObservableCollection<ViewItem> CreateViewItems 
            => new(new List<IAuthenticationViewModel>
            {
                new CardAuthViewModel(),
                new SinglePinAuthViewModel(),
                new MultiPinAuthViewModel()
            }
            .Select(CreateViewItem));

    }
}
