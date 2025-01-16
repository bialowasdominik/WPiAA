namespace TemporaryFields
{
    public class PdfWriter : IDisposable
    {
        private string v;
        private bool _disposed = false;

        public PdfWriter(string v)
        {
            this.v = v;
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
                    Console.WriteLine($"Closing PDF file: {v}");
                }
                _disposed = true;
            }
        }

        ~PdfWriter()
        {
            Dispose(false);
        }

        public void Write(String invoceContent)
        {
            Console.WriteLine($"Generated invoice {v} with content {invoceContent}");
        }
    }
}
