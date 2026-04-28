namespace BlazorApp.Services
{
    public class AuthService
    {
        public string CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;
        public Action onChange;

        public void Login(string user)
        {
            CurrentUser = user;
            NotifyStateChanged();
        }

        public void Logout()
        {
            CurrentUser = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => onChange?.Invoke();
    }
}


