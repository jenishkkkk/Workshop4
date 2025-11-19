namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.playerName = "jen";
            player.level = 2;
            player.health = 399;

            Player player1 = new Player("jen3", 3, 900);

            Console.WriteLine("\nPlayer Details:");
            Console.WriteLine($"Name: {player.playerName}, Level: {player.level}, Health: {player.health}");


            Console.WriteLine("\nPlayer 1 Details:");
            Console.WriteLine($"Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");
        }
    }
}