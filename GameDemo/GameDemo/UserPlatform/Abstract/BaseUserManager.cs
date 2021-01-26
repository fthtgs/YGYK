using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.UserPlatform.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Register(User user)
        {
            Console.WriteLine("{0} kullanıcının kaydı başarılı.", user.UserName);
        }
        public virtual void Remove(List<User> users, int i)
        {
            Console.WriteLine("{0} adlı kullanıcının hesabı silinmiştir.", users[i].UserName);
            users.Remove(users[i]);
        }

        public virtual void Update(List<User> users, int i)
        {
            Console.WriteLine("Lütfen yeni şifrenizi giriniz:");
            string newPassword = Console.ReadLine();
            users[i].UserPassword = newPassword;
            Console.WriteLine("Şifreniz başarıyla değiştirilmiştir.");
        }
    }
}
