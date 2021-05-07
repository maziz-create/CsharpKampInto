using GameDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Entities
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
