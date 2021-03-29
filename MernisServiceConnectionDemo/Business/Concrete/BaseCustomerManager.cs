using MernisServiceConnectionDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisServiceConnectionDemo.Business.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)    // virtual anahtar kelimesi bu metodun ezilebilmesini sağlar
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }

       
    }
}
