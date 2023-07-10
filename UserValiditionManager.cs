using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValiditonManager : IUserValiditonService
    {
        public bool Validate(Gamer gamer)
        {

            if(gamer.BirthYear == 1985 && gamer.FirstName =="SELİN" && gamer.LastName == "CAN" && gamer.IdentityNumber ==12345)
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


