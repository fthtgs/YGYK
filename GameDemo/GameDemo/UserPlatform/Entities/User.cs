using GameDemo.UserPlatform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.UserPlatform.Entities
{
    public class User : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
