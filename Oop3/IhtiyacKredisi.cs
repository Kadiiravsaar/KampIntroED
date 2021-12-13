using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class IhtiyacKredisi : IKrediManager // eğer interface yani kalıtım yapılıyorsa bunun adı implamente
    {

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplanıyor...\n");
        }

        public void BiseyYap()
        {

        }
    }
}
