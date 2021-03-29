using MernisServiceConnectionDemo.Business.Abstract;
using MernisServiceConnectionDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisServiceConnectionDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
