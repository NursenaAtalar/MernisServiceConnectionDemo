using MernisServiceConnectionDemo.Business.Abstract;
using MernisServiceConnectionDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace MernisServiceConnectionDemo.Business.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }

}
