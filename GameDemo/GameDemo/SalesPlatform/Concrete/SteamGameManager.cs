using GameDemo.DataBasePlatform.Abstract;
using GameDemo.SalesPlatform.Abstract;
using GameDemo.SalesPlatform.Entities;
using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.SalesPlatform.Adapters
{
    public class SteamGameManager : BaseGameManager
    {
        public override void Sale(User user, Games game, List<ILoggerService> loggerServices)
        {
            base.Sale(user, game, loggerServices);
        }
    }
}
