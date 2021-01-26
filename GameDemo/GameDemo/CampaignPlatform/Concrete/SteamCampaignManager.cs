using GameDemo.CampaignPlatform.Abstract;
using GameDemo.CampaignPlatform.Entites;
using GameDemo.SalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.CampaignPlatform.Concrete
{
    class SteamCampaignManager : BaseCampaignManager
    {
        public override void CampaignSale(Games game, Campaign campaigns)
        {
            base.CampaignSale(game, campaigns);
        }
        public override void UpdateCampaign(Games game, List<Campaign> campaigns, int i)
        {
            base.UpdateCampaign(game,campaigns,i);
        }
        public override void RemoveCampaign(List<Campaign> campaigns, int i)
        {
            base.RemoveCampaign(campaigns, i);
        }
    }
}
