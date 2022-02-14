using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokToGame
{
    internal class TikTakTo_Bord
    {
        char[] position = new char[10];


        public void TikTakToBord()
        {
            //for (int i = 0; i < position.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    position[i] = ' ';
            //}
            Console.WriteLine("{0}\t|{1}\t|{2}", position[0], position[1], position[2]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0}\t|{1}\t|{2}", position[3], position[4], position[5]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0}\t|{1}\t|{2}", position[6], position[7], position[8]);
        }
        public void takeInput()
        {
            char a2 = 'l';
            char a = 'l';
            int count = 0;
            int player = 1;
            if (position != null)
            {
                while (true)
                {
                    if (player == 1)
                    {
                        
                        if (a == 'l')
                        {
                            Console.WriteLine("Select first player choice X or O");
                            a = char.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Play First plauer your mark is "+a);
                        int dis = Int32.Parse(Console.ReadLine());
                        if (position[dis] != 'X' && position[dis] != 'O')
                        {
                            position[dis] = a;
                            TikTakToBord();
                            player = 2;
                        }
                        else
                        {
                            Console.WriteLine("this position have " + position[dis]);
                        }
                    }
                    else if (player == 2)
                    {                       
                        if (a2 == 'l')
                        {
                            Console.WriteLine("Select second player choice X or O");
                            a2 = char.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Play second plauer your mark is "+a2);
                        int di = Int32.Parse(Console.ReadLine());
                        if (position[di] != 'X' && position[di] != 'O')
                        {
                            position[di] = a2;
                            TikTakToBord();
                            player = 1;
                        }
                        else
                        {
                            Console.WriteLine("this position have "+position[di]);
                        }
                    }
                    count++;
                    if(count==9)
                        break;
                }
            }

        }
    }
    
}
