using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo.Concrete
{
    public class PersonManager:IPersonService
    {
        private IPersonCheckService _personCheckService;

        public PersonManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

     

        public void Save(Person person)
        {
            if (_personCheckService.CheckIfRealPerson(person))
            {
                Console.WriteLine("Kullanıcı kayıt edildi : " + person.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }


        public void Update(Person person)
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi : " + person.FirstName);
        }

        public void Delete(Person person)
        {
            Console.WriteLine("Kullanıcı silindi : " +person.FirstName);
        }
    }
}
