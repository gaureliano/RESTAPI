using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPI.Controllers.Model;
using RESTAPI.Data.VO;

namespace RESTAPI.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);

        PersonVO FindByID(long id);

        List<PersonVO> FindAll();

        PersonVO Update(PersonVO person);

        void Delete(long id);
    }
}
