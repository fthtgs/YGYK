using GameDemo.UserPlatform.Abstract;
using GameDemo.UserPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.UserPlatform.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        private string FirstName = "Fatih";
        private string LastName = "Toğuş";
        private int Year = 1996;
        private string NationalityID = "1111111111";

        public bool CheckIfRealPerson(User user)
        {
            if (user.FirstName.Equals(FirstName) && user.LastName.Equals(LastName) && user.DateOfBirth.Year.Equals(Year) && user.NationalityID.Equals(NationalityID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
