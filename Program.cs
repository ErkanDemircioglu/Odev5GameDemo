using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Adapters;
using Odev5GameDemo.Concrete;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1=new Person();
            person1.Id = 1;
            person1.FirstName = "Erkan";
            person1.LastName = "Demircioğlu";
            person1.NationalityId = "1111111111111";
            person1.DateOfBirth = new DateTime(1981, 9, 30);

            Person person2 = new Person();
            person2.Id = 2;
            person2.FirstName = "Ahmet";
            person2.LastName = "Demir";
            person2.NationalityId = "1111111111112";
            person2.DateOfBirth = new DateTime(1981, 2, 2);

            Game game1=new Game();
            game1.Id = 1;
            game1.Name = "Diablo II";
            game1.PersonId = 1;
            game1.UnitPrice = 25;

            Game game2=new Game();
            game2.Id = 2;
            game2.PersonId = 2;
            game2.Name = "Warcraft";
            game2.UnitPrice = 50;

            Campaign campaign1=new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Tüm oyunlarda %10 indirim";
            campaign1.CampaignStartTime=DateTime.Today;
            campaign1.CampaignFinishTime=DateTime.Today;

            Campaign campaign2=new Campaign();
            campaign2.Id = 2;
            campaign2.CampaignName = "Yeni üye olana %50 indirim";
            campaign2.CampaignStartTime=DateTime.Today;
            campaign2.CampaignFinishTime=DateTime.Today;

            PersonManager personManager = new PersonManager(new MernisServiceAdapter());
            personManager.Save(person1);

            personManager.Update(new Person
            {
                DateOfBirth = new DateTime( 1980,12,1),
                FirstName = "Erkan",
                LastName = "Demircioğlu",
                NationalityId = "111111111111"
            });

            GameManager gameManager = new GameManager();
            gameManager.Buy(person1,game2);

            CampaingManager campaingManager=new CampaingManager();
            campaingManager.Add(campaign1);
            campaingManager.Update(campaign2);
           
            Console.ReadLine();

        }
    }
}
