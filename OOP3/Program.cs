using System;
using System.Collections.Generic;
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IKrediManager Interface'i sayesinde kredilere dair referans kodu yani adres aldık. Adresleri çok önemli.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
