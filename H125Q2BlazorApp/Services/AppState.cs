using System;

namespace H125Q2BlazorApp.Services
{
    public class AppState : IDisposable
    {
        private int _tæller = 0;
        private bool _disposed = false;

        public int Tæller
        {
            get => _tæller;
            set
            {
                if (_tæller != value)
                {
                    _tæller = value;
                    NotifyStateChanged();
                }
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        public void ØgTæller()
        {
            Tæller++;
        }

        public void NulstilTæller()
        {
            Tæller = 0;
        }

        public void Inkrementer()
        {
            Tæller++;
        }

        public void Dekrementer()
        {
            Tæller--;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Frigør eventuelle ressourcer her
                    OnChange = null;
                }

                _disposed = true;
            }
        }
    }
} 