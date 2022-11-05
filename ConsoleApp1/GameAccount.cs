namespace ConsoleApp1;

public class GameAccount
{
    public readonly string username;
    private int _currentRating;
    private int _gamesCount;
    private readonly List<GameResults> _history = new ();

    public GameAccount(string username, int currentRating)
    {
        this.username = username;
        _currentRating = currentRating;
        _gamesCount = 0;
    }

    public int CurrentRating
    {
        get => _currentRating;
        set
        {
            if (value < 1) _currentRating = 1;
            else _currentRating = value;
        }
    }

    public void WinGame(string opponentName, int rating, int id)
    {
        CurrentRating += rating;
        _gamesCount++;
        _history.Add(new GameResults(username, opponentName, rating, _currentRating, _gamesCount, id, '+'));
    }
    
    public void LoseGame(string opponentName, int rating, int id)
    {
        CurrentRating -= rating;
        _gamesCount++;
        _history.Add(new GameResults(username, opponentName, rating, _currentRating, _gamesCount, id, '-'));
    }

    public void GetStats()
    {
        foreach (var gameData in _history)
        {
            Console.WriteLine("Game №" + gameData.id + ". "
                              + gameData.username + " vs " + gameData.opponentName
                              + " - Result of the game: (" + gameData.symbol + gameData.ratingPerGame + ")"
                              + ". Your rating: " + gameData.currentRating 
                              + ". Games you played: " +  gameData.gamesCount);
        }
    }
}