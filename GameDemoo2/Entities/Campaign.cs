using GameDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Entities
{
    public class Campaign : ICampaign
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public double Discount { get; set; }
    }
}
