using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPI.Controllers.Model;
using RESTAPI.Model.Base;

namespace RESTAPI.Business
{
    public interface IRepository<T> where T : BaseEntity


    {
        T Create(T item);

        T FindByID(long id);

        List<T> FindAll();

        T Update(T item);

        void Delete(long id);

        bool Exists(long id);
    }
}
