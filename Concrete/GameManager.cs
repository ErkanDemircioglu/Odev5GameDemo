using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo.Concrete
{
    public class GameManager:IGameService
    {
        public void Buy(Person person, Game game)
        {
            Console.WriteLine(game.Name+ " isimli oyun " + person.FirstName +" tarafından satın alındı");
        }
    }
}
