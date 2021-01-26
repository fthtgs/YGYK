using GameDemo.UserPlatform.Abstract;
using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.UserPlatform.Concrete
{
    public class SteamUserManager : BaseUserManager
    {
        private IUserCheckService _userCheckService;
        public SteamUserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public override void Register(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Register(user);
            }
            else
            {
                throw new Exception("Not a valid person!");
            }
        }
        public override void Remove(List<User> users, int i)
        {
            base.Remove(users, i);
        }
        public override void Update(List<User> users, int i)
        {
            base.Update(users, i);
        }
    }
}
