using GameDemo2.Abstract;
using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Concrete
{
    public class CSGOManager : BaseGameManager
    {
        public override void Delete(Game game, User user)
        {
            Console.WriteLine("-----CSGO-----");
            base.Delete(game, user);
        }

        public override void Play(Game game, User user)
        {
            Console.WriteLine("-----CSGO-----");
            base.Play(game, user);
        }

        public override void Save(Game game, User user)
        {
            Console.WriteLine("-----CSGO-----");
            base.Save(game, user);
        }
    }
}
