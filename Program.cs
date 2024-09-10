namespace Part_5._5_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            dice1.DrawDice();
            dice2.DrawDice();
            Console.WriteLine("Hello, press ENTER to roll the dices!");
            Console.ReadLine();
            Roll(dice1 , dice2);
            while (Console.ReadLine() != "Quit")
            {
                Roll(dice1, dice2);
            }

        }
        public static void Roll(Dice dice1, Dice dice2)
        {
            Console.Clear();
            dice1.RollDice();
            dice2.RollDice();
            dice1.DrawDice();
            dice2.DrawDice();
            if (dice1.Roll == dice2.Roll)
            {
                Console.WriteLine("They have the same value!");
                if (dice1.Roll == 1)
                {
                    Console.WriteLine("It's snake eyes!");
                }
                Console.WriteLine("It's a double!");
            }
            else if (dice1.Roll > dice2.Roll)
            {
                Console.WriteLine("The first dice is bigger!");
                if (dice1.Roll == dice2.Roll + 1)
                {
                    Console.WriteLine("They are sequential!");
                }
            }
            else if (dice1.Roll < dice2.Roll)
            {
                Console.WriteLine("The second dice is bigger!");
                if (dice1.Roll == dice2.Roll - 1)
                {
                    Console.WriteLine("They are sequential!");
                }
            }
            if (dice1.Roll + dice2.Roll == 7)
            {
                Console.WriteLine("They have a sum of 7!");

            }
            if ((dice1.Roll + dice2.Roll) % 2 == 0)
            {
                Console.WriteLine("They have an even sum!");
            }

            Console.WriteLine("Type \"Quit\" to exit the program, or ENTER to continue!");
        }
    }
}
