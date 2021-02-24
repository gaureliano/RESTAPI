using RESTAPI.Business;
using RESTAPI.Controllers.Model;

namespace RESTAPI.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
