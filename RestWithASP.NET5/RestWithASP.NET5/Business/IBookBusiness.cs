using RestWithASP.NET5.Data.VO;
using System.Collections.Generic;
namespace RestWithASP.NET5.Business
{
    public interface IBookBusiness
    {
        List<BookVO> FindAll();
        BookVO FindById(long id);
        BookVO Create(BookVO book);
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
