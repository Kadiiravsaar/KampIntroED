using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bu şekilde de yapılabilir interface onu implamente eden clasın referansını tutabilir
           
            //KonutKredisi konutKredisi = new KonutKredisi();
            //konutKredisi.Hesapla();

            //TasitKredisi tasitKredisi = new TasitKredisi();
            //tasitKredisi.Hesapla();

            //IhtiyacKredisi ihtiyacKredisi = new IhtiyacKredisi();
            //ihtiyacKredisi.Hesapla();


            //IKrediManager konutKredisi = new KonutKredisi();
            //konutKredisi.Hesapla();

            //IKrediManager tasitKredisi = new TasitKredisi();
            //tasitKredisi.Hesapla();

            //IKrediManager ihtiyacKredisi = new IhtiyacKredisi();
            //ihtiyacKredisi.Hesapla();

            // -------------------------------------------------------------------------------

            IKrediManager konutKredisi = new KonutKredisi();
            IKrediManager tasitKredisi = new TasitKredisi();
            IKrediManager ihtiyacKredisi = new IhtiyacKredisi();

            IDbManager db = new DataBaseLogger();
            IDbManager file = new FileLogger();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKredisi,db);
            //basvuruManager.BasvuruYap(tasitKredisi);
            //basvuruManager.BasvuruYap(ihtiyacKredisi);

            // ----------------------------------

            List<IKrediManager> krediler = new List<IKrediManager>
            { konutKredisi,ihtiyacKredisi,tasitKredisi};

            
            //basvuruManager.KrediBilgilendirmesi(krediler);
            //IDbManager db = new DataBaseLogger();
            //IDbManager file = new FileLogger();

            //db.Hesapla();
            //file.Hesapla();




            Console.ReadLine();
           
        }
    }
}
