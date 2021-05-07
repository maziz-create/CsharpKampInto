using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Abstract
{
    public abstract class BaseGameManager
    {
        //oyuncu olarak kayıt ol(aynı), oyuncu kaydını sil(farklı), oyunu oyna(farklı)
        public virtual void Save(Game game, User user)
        {
            Console.WriteLine(user.FirstName + " isimli kişi " + game.Name + " isimli oyuna kaydoldu.");
        }

        public virtual void Play(Game game, User user)
        {
            Console.WriteLine(game.Name + " isimli oyun " + user.FirstName + " tarafından oynandı.");
        }

        public virtual void Delete(Game game, User user)
        {
            Console.WriteLine(user.FirstName + " isimli oyuncunun kaydı " + game.Name + " isimli oyundan silindi.");
        }

        public void GameSetup(Game game)
        {
            Console.WriteLine(game.Name + " İsimli Oyunun kurulumu tamamlandı.");
        }
    }
}
