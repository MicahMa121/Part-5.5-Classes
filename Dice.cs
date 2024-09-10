using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5._5_Classes
{
    public class Dice
    {
        private Random _gen = new Random();
        private int _roll ;
        public int Roll { get { return _roll; } }
        public Dice() 
        {
            RollDice();
        }
        public void RollDice()
        {
            _roll = _gen.Next(1, 7);
        }
        public override string ToString()
        {
            return _roll.ToString();
        }
        public void DrawDice()
        {
            switch (_roll)
            {
                case 1:
                    Console.WriteLine("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----\r\n");
                    break;
                case 2:
                    Console.WriteLine("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
                    break;
                case 3:
                    Console.WriteLine("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----");
                    break;
                case 4:
                    Console.WriteLine("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----");
                    break;
                case 5:
                    Console.WriteLine("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----");
                    break;
                case 6:
                    Console.WriteLine("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
                    break;
            }
        }
    }
}
