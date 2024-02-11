using Business.Abstract;
using Entites.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business.Concrete
{
    public class CitizenManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList() 
        {

            return null;

        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationanalIdentitiy,Ad: person.Firstname,Soyad: person.Lastname,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
        
    }
}
