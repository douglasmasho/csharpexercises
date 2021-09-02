using System;

namespace ClassEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSoccerPlayer player = new TestSoccerPlayer();

            player.Name = "Jackie Chan";
            player.Number = 1;
            player.Goals = 100;

            Console.WriteLine($"The player {player.Name} jersey number {player.Number} has {player.Goals} goals");
        }
    }
}
