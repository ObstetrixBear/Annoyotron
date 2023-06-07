namespace Annoyotron.ViewModels
{
    public interface IAuthenticationViewModel
    {
        public bool Authenticated { get; }
        
        public bool Authenticate();
    }
}
