using MernisServiceConnectionDemo.Business.Abstract;
using MernisServiceConnectionDemo.Entities;
using System;

namespace MernisServiceConnectionDemo.Business.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
        }

    }

}
