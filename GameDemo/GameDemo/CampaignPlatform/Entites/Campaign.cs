using GameDemo.CampaignPlatform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.CampaignPlatform.Entites
{
    public class Campaign : IEntity
    {
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
