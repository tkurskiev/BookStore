namespace BookStore.API.Exceptions
{
    public class DbException : Exception
    {
        public DbException(string? message, Exception? ex) : base(message, ex)
        {
        }

        public DbException(string? message) : base(message)
        {
        }
    }
}
