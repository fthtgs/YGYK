using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.UserPlatform.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
