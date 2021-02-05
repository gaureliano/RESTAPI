using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RESTAPI.Controllers.Model;
using RESTAPI.Model.Context;

namespace RESTAPI.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Update(Book person)
        {
            return _repository.Update(person);
        }

    }
}
