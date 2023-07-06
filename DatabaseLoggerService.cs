using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
	 class DatabaseLoggerService: ILoggerService
	{
		public void Log()
		{
			//throw new NotImplementedException();

			Console.WriteLine("Veritabanına loglandı");
		}
	}

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Veritabanına loglandı");
        }
    }
}

