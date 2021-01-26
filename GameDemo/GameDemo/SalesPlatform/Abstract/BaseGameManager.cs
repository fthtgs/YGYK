using GameDemo.DataBasePlatform.Abstract;
using GameDemo.SalesPlatform.Entities;
using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.SalesPlatform.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public virtual void Sale(User user, Games game, List<ILoggerService> loggerServices)
        {
            Console.WriteLine("{0} adlı oyun {1} adlı kullanıcıya satıldı.",game.GameName,user.UserName);

            //log kayıtları için
            foreach (var log in loggerServices)
            {
                log.Add();
            }

        }
    }
}
