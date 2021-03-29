using System;
using System.Collections.Generic;
using System.Text;

namespace MernisServiceConnectionDemo.Entities
{
    public class Customer :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
