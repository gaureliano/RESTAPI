using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPI.Controllers.Model;
using RESTAPI.Data.VO;

namespace RESTAPI.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO FindByID(long id);

        List<BookVO> FindAll();

        BookVO Update(BookVO book);

        void Delete(long id);
    }
}
