using System;

namespace Oop3
{
class BasvuruManager
	{
		public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
		{ 
			//KonutKrediManager konutKrediManager = new KonutKrediManager();
			//konutKrediManager.Hesapla();

			krediManager.Hesapla();
			loggerService.Log();




		}

		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //ıkredimanager türünde liste

		{
			foreach(var kredi in krediler)
			{
				kredi.Hesapla();

			}

        }
	}
}

