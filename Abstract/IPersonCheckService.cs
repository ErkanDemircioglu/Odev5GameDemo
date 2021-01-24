using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Person person);
    }
}
