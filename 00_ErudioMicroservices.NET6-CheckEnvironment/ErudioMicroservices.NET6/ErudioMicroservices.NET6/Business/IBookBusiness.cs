using ErudioMicroservices.NET6.Data.VO;
using System.Collections.Generic;

namespace ErudioMicroservices.NET6.Business
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
