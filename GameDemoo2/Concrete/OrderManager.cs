using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Concrete
{
    class OrderManager
    {
        public void Sell(User user, Game game, Campaign campaign)
        {
            double fiyat = game.Price * campaign.Discount;
            Console.WriteLine(user.FirstName + " isimli kullanıcı " + game.Name + " isimli oyunu " + campaign.Content + " kampanyasından yararlanarak " + fiyat + " TL karşılığı satın aldı.");
        }

    }
}
