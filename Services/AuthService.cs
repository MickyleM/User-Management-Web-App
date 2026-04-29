namespace BlazorApp.Services
{
    public class AuthService
    {
        private Timer? _timer;
        public int CurrentUserId { get; set; }
        public string CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;
        public Action? OnChange;

        public void Login(int userId, string user)
        {
            CurrentUserId = userId;
            CurrentUser = user;
            StartTimer();
            NotifyStateChanged();
        }

        public void Logout()
        {
            CurrentUserId = 0;
            CurrentUser = null;
            StopTimer();
            NotifyStateChanged();
        }

        public void ResetTimer()
        {
            if(IsLoggedIn)
                StartTimer();
        }

        private void StartTimer()
        {
            StopTimer();
            _timer = new Timer(_ => Logout(), null, TimeSpan.FromMinutes(30), Timeout.InfiniteTimeSpan);
        }

        private void StopTimer()
        {
            _timer?.Dispose();
            _timer = null;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}


