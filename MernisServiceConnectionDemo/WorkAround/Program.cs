using MernisServiceConnectionDemo.Adapters;
using MernisServiceConnectionDemo.Business.Concrete;
using MernisServiceConnectionDemo.Entities;
using System;

namespace MernisServiceConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Business.Abstract.BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = 1997, FirstName = "Nursena", LastName = "Atalar", NationalityId = 48016031700 });
            Console.ReadLine();
        }
    }
}
