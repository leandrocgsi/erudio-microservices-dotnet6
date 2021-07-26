using ErudioMicroservices.NET6.Data.VO;
using System.Collections.Generic;

namespace ErudioMicroservices.NET6.Business
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
