using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokToGame
{
    internal class TikTakTo_Bord
    {
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void TikTakToBord()
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                arr[i] = ' ';
            }

            Console.WriteLine("{0}\t|{1}\t|{2}",arr[1],arr[2],arr[3]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0}\t|{1}\t|{2}",arr[4],arr[5],arr[6]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0}\t|{1}\t|{2}",arr[7],arr[8],arr[9]);
        }

        public void tekInput()
        {
            int player = 1;
            if (arr != null)
            {
                Console.WriteLine("Select your choice");
                char a = char.Parse(Console.ReadLine());

                while (true)
                {
                    if (player == 1)
                    {
                        Console.WriteLine("Play First plauer");
                        int dis = Int32.Parse(Console.ReadLine());
                        if (arr[dis] != 'X' && arr[dis] != 'O')
                        {

                            arr[dis] = a;
                            player = 2;
                        }
                    }
                    else if (player == 2)
                    {
                        Console.WriteLine("Play First plauer");
                        int di = Int32.Parse(Console.ReadLine());
                        if (arr[di] != 'X' && arr[di] != 'O')
                        {
                            arr[di] = a;
                            player = 1;
                        }
                    }
                }
            }

        }
    }
    
}
