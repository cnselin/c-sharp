using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerManager :IGamerService
	{
        IUserValiditonService _userValiditonService;

        public GamerManager (IUserValiditonService userValiditonService)
        {
            _userValiditonService = userValiditonService;
        }

		public void Add(Gamer gamer)
		{
            if(_userValiditonService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu.");
            }

            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız.");
            }
           
		}

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }

    }
}

