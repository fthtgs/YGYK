using GameDemo.CampaignPlatform.Entites;
using GameDemo.SalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.CampaignPlatform.Abstract
{
    public interface ICampaignService
    {
        void CampaignSale(Games game, Campaign campaigns);
        void RemoveCampaign(List<Campaign> campaigns, int i);
        void UpdateCampaign(Games game, List<Campaign> campaigns, int i);
    }
}
