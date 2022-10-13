
namespace ConsoleApp1;

public class Game
{
    static Random rnd = new Random();
    GameAccount MyAccount;
    GameAccount OpponentAccount;
    private int gameID = rnd.Next(999);

    public Game(GameAccount myacc, GameAccount otheracc)
    {
        MyAccount = myacc;
        OpponentAccount = otheracc;
    }
    
    public void GameStart(int rating)
    {
        var value = (GameResults.States)new Random().Next(2);
        if (value == GameResults.States.Win)
        {
            MyAccount.WinGame(OpponentAccount.username, rating, gameID);
            OpponentAccount.LoseGame(MyAccount.username, rating, gameID);
            gameID++;
        }
        else if (value == GameResults.States.Lose)
        {
            MyAccount.LoseGame(OpponentAccount.username, rating, gameID);
            OpponentAccount.WinGame(MyAccount.username, rating, gameID);
            gameID++;
        }
    }
}