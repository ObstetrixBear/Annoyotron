# Annoyotron
Minimalist project for trying out WPF bindings

## Why this project exists
Microsoft created WPF because MFC was untenable. Undoubtedly, WPF is better than MFC. Even so, in terms of ease of use, it's garbage. Specifically, the way you bind things. Microsoft appears to confuse the act of _claiming_ it's intuitive for actual elegance. The two are not the same.

At work, I have a piece of software that (mis)uses bindings. It's almost completely broken at this point, so I wanted to simplify it. This is my attempt at making a toy model of the login system. 

## What have we learned, then?
Don't know about the rest of you, but I've learned the following:
- The way the XAML is implemented can be thought of as a bifurcated class. After all, XAML uses the idea of partial classes; WPF first parses the XAML into code, then adds the code-behind stuff on top.
- XAML wants to hold all the declarative compile-time shit, while the code-behind is meant for stuff that simply cannot be squared with the idea of compile-time declaration.
- Code-behind should ideally be empty. 
- The secret sauce is the DataContext. Basically, with the DataContext line in the XAML, the MainWindowViewModel is instantiated, and it becomes visible to the XAML. You can also set the DataContext directly in the code-behind (`DataContext = new MainWindowViewModel()`), which I did initially, but when doing that, the WPF Designer won't understand what it's seeing. Regardless, that's what allowed binding the ContentControl contents to SelectedView.View.
- To handle changes to the selector, we had to implement the INotifyPropertyChanged interface in the MainWindowViewModel. Apparently, this is *de regeur* in MVVM: ViewModels hold the handlers. Also, the SetField + [state object] + PropertyChanged + OnPropertyChanged pattern is nigh-ubiquitous in these circumstances. 
