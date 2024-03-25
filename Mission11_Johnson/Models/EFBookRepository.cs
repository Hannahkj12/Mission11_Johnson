namespace Mission11_Johnson.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;
        public EFBookRepository(BookstoreContext temp)
        {
            _context = temp;
        }

        //If someone calls EFBookRepository, give them the projects from the context file
        public IQueryable<Book> Books => _context.Books;
    }
}
