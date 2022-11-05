namespace ConsoleApp1;

public class Game
{
    private static readonly Random Rnd = new();
    private readonly GameAccount _myAccount;
    private readonly GameAccount _opponentAccount;
    private int _gameId = Rnd.Next(999);

    public Game(GameAccount myAcc, GameAccount otherAcc)
    {
        _myAccount = myAcc;
        _opponentAccount = otherAcc;
    }
    
    public void GameStart(int rating)
    {
        var value = (GameResults.States)new Random().Next(2);
        
        if (value == GameResults.States.Win)
        {
            _myAccount.WinGame(_opponentAccount.username, rating, _gameId);
            _opponentAccount.LoseGame(_myAccount.username, rating, _gameId);
            _gameId++;
        }
        
        else if (value == GameResults.States.Lose)
        {
            _myAccount.LoseGame(_opponentAccount.username, rating, _gameId);
            _opponentAccount.WinGame(_myAccount.username, rating, _gameId);
            _gameId++;
        }
    }
}