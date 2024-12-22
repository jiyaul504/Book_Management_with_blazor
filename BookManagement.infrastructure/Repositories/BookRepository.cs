using BookManagemen.Application.Interfaces;
using BookManagement.Domain.Entities;
using BookManagement.infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;
        public BookRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            context= factory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
           context.Books.Add(book);
            await context.SaveChangesAsync();
        }

        public Task<List<Book>> GetAllAsync()
        {
           var books = context.Books.ToListAsync();
            return books;
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            var book = await context.Books.FirstOrDefaultAsync(e=>e.Id==id );
            return book;
        }

        public async Task UpdateAsync(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
