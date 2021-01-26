using GameDemo.DataBasePlatform.Abstract;
using GameDemo.SalesPlatform.Entities;
using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.SalesPlatform.Abstract
{
    public interface IGameService
    {
        void Sale(User user, Games game, List<ILoggerService> loggerServices);
    }
}
