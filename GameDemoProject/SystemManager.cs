using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class SystemManager
    {
        
        static void Mains(string[] args)
        {
            //games listesini üretebilmek için main fonksiyon oluşturdum. googlede yıllardır çalışan adam bile bu sorunuma yanıt bırakmadı. geniş bir sorun dedi.
        }
        List<Game> games = new List<Game>()    //game list
        {
            new Game() { Id = 1, Name = "Call Of Duty", Price = 300},
            new Game() { Id = 2, Name = "Counter-Strike", Price = 65},
            new Game() { Id = 3, Name = "Spider-Man", Price = 125},
            new Game() { Id = 4, Name = "GTA-V", Price = 400}
        };
        List<Campaign> campaigns = new List<Campaign>()     //campaign list
        {
            new Campaign() {Id = 1, CampaignContent = "Bahar Kampanyası 1 Alana 1 Hediye", CampaignDateRate = "1-30 Nisan 2021 Tarihleri Arası"},
            new Campaign() {Id = 2, CampaignContent = "Süper Nisan Günleri Kampanyası 3 Alana 2 Hediye", CampaignDateRate = "19-20-21 Nisan 2021 Tarihleri arası"}
        };

        MernisVerification mernisVerification;                              // e devletteki polat bilgileri ile kayıtlı polat bilgileri karşılaştırılır.
        GetDataFromUser getDataFromUser;                                    // kullanıcıdan kayıt olma verilerini alıyor.
        SalesManager salesManager;                                          // kullanıcının seçtiği oyun id ' ini satın almasını sağlıyor.
        CustomerManager customerManager = new CustomerManager();            // üye kişi kendine dair silme ve güncelleme işlemi yapacak.
        public void ListGames()
        {
            
            foreach (var game in games)
            {
                Console.WriteLine("\n\nId: "+game.Id+" İsim: "+game.Name+" Fiyat: "+game.Price);
            }
        }
        public void ListCampaigns()
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("\n\nKampanya Id: "+campaign.Id+"\nKampanya İçeriği: "+campaign.CampaignContent+ "\nKampanya Geçerlilik Tarih Aralığı: " + campaign.CampaignDateRate);
            }
        }

        public void Login(Customer gamer1)     //gamer1 giriş yapıyor.
        {
            int verification = 0, selection = 0;
            do
            {
                Console.WriteLine("1-Giriş Yap\t2-Kayıt Ol");
                selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {                  
                    mernisVerification = new MernisVerification(gamer1, ref verification);
                    if (verification == 1) Console.WriteLine("Mernis Doğrulaması Başarılı!\n\nBilgileriniz aşağıdadır.");
                    Console.WriteLine("İsminiz: " + gamer1.FirstName + " " + gamer1.LastName); Console.WriteLine("Kimlik Numaranız: " + gamer1.IdentityNumber); Console.WriteLine("Doğum yılınız: " + gamer1.YearOfBirth);
                }
                if (selection == 2)
                {
                    Console.WriteLine("Kayıt için isim, soyisim, tcno ve doğum yılı giriniz.");
                    getDataFromUser = new GetDataFromUser(gamer1);
                    mernisVerification = new MernisVerification(gamer1, ref verification);
                    if (verification == 0) Console.WriteLine("Mernis Doğrulaması başarısız!");
                    else Console.WriteLine("Mernis Doğrulaması Başarılı!");
                }
                
            } while (selection != 1 && verification != 1);
        }
        public int Menu(ref int selectiontest)  //bazı seçimlerden sonra tekrar menüye dönebilmek için
        {
            Console.WriteLine("\n\n1-Oyun Menüsünü Görüntüle\n2-Kampanyaları Görüntüle\n3-Üyelik İşlemleri");
            selectiontest = int.Parse(Console.ReadLine());
            return selectiontest;
        }
        public void HomePage(SystemManager systemManager, GameManager gameManager, ref int selection2, char selection3)
        {
            int selectiontest = 0;
            selection2 = Menu(ref selectiontest);
            if (selection2 == 1)    //Oyun Menüsü
            {
                do
                {
                    Console.WriteLine("\n\na.Oyun Listesi\nb.Oyun Satın Al\n");
                    selection3 = char.Parse(Console.ReadLine());
                    switch (selection3)
                    {
                        case 'a':
                            {
                                ListGames();
                                HomePage(systemManager, gameManager, ref selection2, selection3);
                                break;
                            }
                        case 'b':
                            {
                                Console.WriteLine("Hangi oyunu almak istersiniz? Lütfen Id numarasını belirtin.");
                                ListGames();
                                int satilanoyunid = int.Parse(Console.ReadLine());
                                salesManager = new SalesManager();
                                string text = salesManager.Sell(games, satilanoyunid);
                                Console.WriteLine(text);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Lütfen geçerli bir harf giriniz.");
                                break;
                            }
                    }
                } while (selection3 != 'd');
            }
            else if (selection2 == 2) // Kampanyaları Görüntüle
            {
                ListCampaigns();
                HomePage(systemManager, gameManager, ref selection2, selection3); 
            }
            else if (selection2 == 3) // Üyelik Bilgilerimi Güncelle
            {
                Console.WriteLine("\n\na.Üyeliğimi Sil\nb.Üyelik Bilgilerimi Güncelle");
                selection3 = char.Parse(Console.ReadLine());
                switch (selection3)
                {
                    case 'a':
                        {
                            customerManager.Delete();
                            break;
                        }
                    case 'b':
                        {
                            customerManager.Update();
                            HomePage(systemManager, gameManager, ref selection2, selection3);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lütfen geçerli bir harf giriniz.");
                            break;
                        }
                }
            }
        }

        
    }   
}
