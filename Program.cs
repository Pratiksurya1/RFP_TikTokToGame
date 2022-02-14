using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokToGame
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            TikTakTo_Bord tikTakTo=new TikTakTo_Bord();
            tikTakTo.TikTakToBord();
            tikTakTo.tekInput();
            tikTakTo.TikTakToBord();
        }
    }
}
