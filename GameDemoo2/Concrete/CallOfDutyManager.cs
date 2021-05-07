using GameDemo2.Abstract;
using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Concrete
{
    public class CallOfDutyManager : BaseGameManager
    {
        public override void Delete(Game game, User user)
        {
            Console.WriteLine("-----CALLOFDUTY-----");
            base.Delete(game, user);
        }

        public override void Play(Game game, User user)
        {
            Console.WriteLine("-----CALLOFDUTY-----");
            base.Play(game, user);
        }

        public override void Save(Game game, User user)
        {
            Console.WriteLine("-----CALLOFDUTY-----");
            base.Save(game, user);
        }
    }
}
