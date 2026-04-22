namespace BlazorApp.Services
{
    public class AuthService
    {
        public User CurrentUser { get; private set; }
        public bool isLoggedIn => CurrentUser != null;
        public Action onChange;

        public void Login(User user)
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


