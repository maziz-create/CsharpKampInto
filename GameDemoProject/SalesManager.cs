using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class SalesManager
    {
        public string Sell(List<Game> games ,int satilanoyunid)
        {
            string text="";
            switch (satilanoyunid)
            {
                case 1:
                    {
                        text = "Call Of Duty oyunu başarıyla satın alındı!";
                        break;
                    }
                case 2:
                    {
                        text = "Counter-Strike oyunu başarıyla satın alındı!";
                        break;
                    }
                case 3:
                    {
                        text = "Spider-Man oyunu başarıyla satın alındı!";
                        break;
                    }
                case 4:
                    {
                        text = "GTA-V oyunu başarıyla satın alındı!";
                        break;
                    }
                default:
                    break;
            }

            return text;
        }
    }
}
