namespace ConsoleApp1;

internal static class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Game Started!");
        
        GameAccount myAccount = new GameAccount("Vadim", 200);
        GameAccount opponentAccount = new GameAccount("Bot", 240);
        Game mainGame = new Game(myAccount, opponentAccount);

        mainGame.GameStart(52);
        mainGame.GameStart(58);
        mainGame.GameStart(54);
        mainGame.GameStart(50);
        mainGame.GameStart(56);
        
        Console.WriteLine("----------------------------------------Your Career---------------------------------------");
        myAccount.GetStats();
        
        Console.WriteLine("-------------------------------------Opponent's Career-------------------------------------");
        opponentAccount.GetStats();
    }
}