using System;

namespace EasyWeb.Data
{
    public class Disposable : IDisposable
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                DisposeCore();
            }
            disposed = true;
        }
        protected virtual void DisposeCore()
        { 
        }
    }
}
