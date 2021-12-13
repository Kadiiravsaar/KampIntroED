using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class FileLogger:IDbManager
    {
        public void Log()
        {
            Console.WriteLine("Dosya üzerine Loglanıyor...");
        }
        public void BiseyYap()
        {

        }
    }
}
