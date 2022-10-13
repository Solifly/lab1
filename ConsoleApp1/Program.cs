namespace ConsoleApp1;

internal static class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Game Started!");
        
        GameAccount MyAccount = new GameAccount("Vadim", 500);
        GameAccount OpponentAccount = new GameAccount("Bot", 540);
        Game MainGame = new Game(MyAccount, OpponentAccount);

        MainGame.GameStart(30);
        MainGame.GameStart(28);
        MainGame.GameStart(23);
        MainGame.GameStart(30);
        MainGame.GameStart(26);
        Console.WriteLine("----------------------------------------Your Career---------------------------------------");
        MyAccount.GetStats();
        Console.WriteLine("-------------------------------------Opponent's Career-------------------------------------");
        OpponentAccount.GetStats();
        
    }
}