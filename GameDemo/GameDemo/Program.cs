using GameDemo.SalesPlatform.Abstract;
using GameDemo.SalesPlatform.Entities;
using GameDemo.SalesPlatform.Adapters;
using GameDemo.UserPlatform.Abstract;
using GameDemo.UserPlatform.Adapters;
using GameDemo.UserPlatform.Concrete;
using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using GameDemo.CampaignPlatform.Abstract;
using GameDemo.CampaignPlatform.Concrete;
using GameDemo.CampaignPlatform.Entites;
using GameDemo.DataBasePlatform.Abstract;
using GameDemo.DataBasePlatform.Concrete;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUserManager userManager = new SteamUserManager(new MernisServiceAdapter());
            List<User> users = new List<User>();
            users.Add(new User { FirstName = "Fatih", LastName = "Toğuş", NationalityID = "1111111111", DateOfBirth = new DateTime(1996, 6, 15),
                UserName = "fthtgs", UserPassword = "159357" });
            /*
            User user1 = new User();
            user1.FirstName = "Fatih";
            user1.LastName = "Toğuş";
            user1.NationalityID = "1111111111";
            user1.DateOfBirth = new DateTime(1996, 6, 15);
            user1.UserName = "fthtgs";
            user1.UserPassword = "159357";
            */
            userManager.Register(users[0]);

            BaseGameManager gameManager = new SteamGameManager();
            List<Games> games = new List<Games>();
            games.Add(new Games { GameName = "Divinity Original Sin Enhanced Edition", GamePrice = 131 });
            games.Add(new Games { GameName = "Divinity Original Sin Enhanced Edition 2", GamePrice = 226 });
            /*
            Games game1 = new Games();
            game1.GameName = "Divinity Original Sin Enhanced Edition";
            game1.GamePrice = 150;
            */

            gameManager.Sale(users[0], games[0], new List<ILoggerService> { new DatabaseLoggerService(), new EmailLoggerService() });
            gameManager.Sale(users[0], games[1], new List<ILoggerService> { new DatabaseLoggerService(), new EmailLoggerService() });

            BaseCampaignManager campaignManager = new SteamCampaignManager();
            List<Campaign> campaigns = new List<Campaign>();

            campaigns.Add(new Campaign { CampaignName = "Kış İndirimi", CampaignDiscount = 0.5 });
            campaigns.Add(new Campaign { CampaignName = "Haftasonu İndirimi", CampaignDiscount = 0.2 });
            Console.WriteLine("----------");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }
            Console.WriteLine("----------");
            campaignManager.CampaignSale(games[0], campaigns[0]);
            Console.WriteLine("----------");
            campaignManager.CampaignSale(games[1], campaigns[1]);
            Console.WriteLine("----------");
            campaignManager.UpdateCampaign(games[0],campaigns,0);
            Console.WriteLine("----------");
            campaignManager.RemoveCampaign(campaigns,1);
            Console.WriteLine("----------");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }

            Console.WriteLine("----------");
            Console.WriteLine("Eski şifre : " + users[0].UserPassword);
            userManager.Update(users, 0);
            Console.WriteLine("Yeni şifre : " + users[0].UserPassword);
            Console.WriteLine("----------");
            userManager.Remove(users, 0);
            foreach (var user in users)
            {
                Console.WriteLine(user.UserName);
            }

            





        }
    }
}
