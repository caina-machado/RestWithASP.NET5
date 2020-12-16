using RestWithASP.NET5.Model;
using System.Collections.Generic;

namespace RestWithASP.NET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        Person Update(Person person);
        void Delete(long id);
    }
}
