using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPI.Controllers.Model;

namespace RESTAPI.Business
{
    public interface IBookRepository

    {
        Book Create(Book person);

        Book FindByID(long id);

        List<Book> FindAll();

        Book Update(Book person);

        void Delete(long id);

        bool Exists(long id);
    }
}
