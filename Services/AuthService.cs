namespace BlazorApp.Services
{
    public class AuthService
    {
        public int CurrentUserId { get; set; }
        public string CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;
        public Action onChange;

        public void Login(int userId, string user)
        {
            CurrentUserId = userId;
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


