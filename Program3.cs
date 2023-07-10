using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValiditonManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "SELİN", LastName = "CAN" ,IdentityNumber=12345});

        }
    }
}