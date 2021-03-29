using MernisServiceConnectionDemo.Entities;

namespace MernisServiceConnectionDemo.Business.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
