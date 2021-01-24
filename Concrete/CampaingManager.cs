using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;
using Odev5GameDemo.Entities;

namespace Odev5GameDemo.Concrete
{
    public class CampaingManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" yeni kampanya eklendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  kampanya güncellendi");
        }
    }
}
