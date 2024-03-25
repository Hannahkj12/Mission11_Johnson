namespace Mission11_Johnson.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
