using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;

namespace Odev5GameDemo.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; } 
        public decimal UnitPrice { get; set; }
    }
}
