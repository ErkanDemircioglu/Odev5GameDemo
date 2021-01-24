using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            // E devlet sistemi üzerinden doğrulama işlemleri
            return true;
        }
    }
}
