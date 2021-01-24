using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo.Concrete
{
    public class PersonCheckManager:IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}
