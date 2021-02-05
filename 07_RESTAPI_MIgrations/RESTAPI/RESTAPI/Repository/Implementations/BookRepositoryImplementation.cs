using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RESTAPI.Business;
using RESTAPI.Controllers.Model;
using RESTAPI.Model.Context;

namespace RESTAPI.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {
        private MySQLContext _context;
        private long id;

        public BookRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Book Create(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return book;
        }

        public void Delete(long name)
        {
            var result = _context.Books.SingleOrDefault(p => p.ID.Equals(name));

            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindByID(long id)
        {
            return _context.Books.SingleOrDefault(p => p.ID.Equals(id));
        }

        public Book Update(Book book)
        {
            if (!Exists(book.ID)) return new Book();

            var result = _context.Books.SingleOrDefault(p => p.ID.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return book;
        }
        
        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Title.Equals(id));
        }

    }
}
