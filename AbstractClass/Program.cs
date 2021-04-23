using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MevzuatBase aMevzuat = new MevzuatA();
            aMevzuat.Degerlendir();
            aMevzuat.Save();
            Console.WriteLine("-----------------------------");
            MevzuatBase bMevzuat = new MevzuatB();
            bMevzuat.Degerlendir();
            bMevzuat.Save();
        }
    }

    abstract class MevzuatBase
    {
        public abstract void Degerlendir(); //içi boş imza fonksiyon
        public void Save()
        {
            Console.WriteLine("Mevzuat Kaydedildi.");
        }
    }

    class MevzuatA : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi.");
        }
    }
    class MevzuatB : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuatına göre değerlendirildi.");
        }
    }

}
