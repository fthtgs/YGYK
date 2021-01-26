using GameDemo.CampaignPlatform.Entites;
using GameDemo.SalesPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GameDemo.CampaignPlatform.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public virtual void CampaignSale(Games game,Campaign campaigns)
        {
            double newGamePrice;
            newGamePrice = (1.0 - campaigns.CampaignDiscount) * game.GamePrice;
            Console.WriteLine("{0} yeni fiyatı {1} TL",game.GameName, newGamePrice);
        }

        public virtual void RemoveCampaign(List<Campaign> campaigns,int i)
        {
            Console.WriteLine("{0} kampanyası bitmiştir.", campaigns[i].CampaignName);
            campaigns.Remove(campaigns[i]);
        }

        public virtual void UpdateCampaign(Games game,List<Campaign> campaigns, int i)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            Console.WriteLine("Yeni kampanya indirimini giriniz.");
            double newCampaignDiscount = Convert.ToDouble(Console.ReadLine(),provider);
            game.GamePrice = Math.Round(((1.0 - newCampaignDiscount) * game.GamePrice),2);
            
            Console.WriteLine("{0} yeni fiyatı {1} TL", game.GameName, game.GamePrice);
        }
    }
}
