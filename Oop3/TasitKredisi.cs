using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class TasitKredisi: IKrediManager // eğer interface yani kalıtım yapılıyorsa bunun adı implamente
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplanıyor...\n");
        }
        public void BiseyYap()
        {

        }

    }
}
