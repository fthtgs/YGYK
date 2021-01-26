using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.UserPlatform.Abstract
{
    public interface IUserService
    {
        void Register(User user);
        void Remove(List<User> users, int i);
        void Update(List<User> user, int i);
    }
}
