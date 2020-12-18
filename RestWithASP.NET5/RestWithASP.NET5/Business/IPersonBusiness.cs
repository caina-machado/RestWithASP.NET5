using RestWithASP.NET5.Data.VO;
using System.Collections.Generic;

namespace RestWithASP.NET5.Business
{
    public interface IPersonBusiness
    {
        List<PersonVO> FindAll();
        PersonVO FindById(long id);
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
