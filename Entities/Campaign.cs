using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev5GameDemo.Abstract;

namespace Odev5GameDemo.Entities
{
    public class Campaign:IEntity
    {
        public int  Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime CampaignStartTime { get; set; }
        public DateTime CampaignFinishTime { get; set; }
    }
}
