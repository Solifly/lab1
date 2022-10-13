namespace ConsoleApp1;

public class GameAccount
{
    public string username;
    public int currentRating;
    public int gamesCount;
    public List<GameResults> history = new ();
    public GameResults gameResults = new GameResults();
    
    public GameAccount(string username, int currentRating)
    {
        this.username = username;
        this.currentRating = currentRating;
        gamesCount = 0;
    }

    public void WinGame(string opponentName, int rating, int ID)
    {
        currentRating += rating;
        gamesCount++;
        history.Add(new GameResults(username, opponentName, rating, currentRating, gamesCount, ID, '+'));
    }
    
    public void LoseGame(string opponentName, int rating, int ID)
    {
        if (currentRating >= rating) currentRating -= rating;
        else currentRating = 1;
        gamesCount++;
        history.Add(new GameResults(username, opponentName, rating, currentRating, gamesCount, ID, '-'));
    }

    public void GetStats()
    {
        foreach (var gameData in history)
        {
            Console.WriteLine("Game №" + gameData.ID + ". "
                              + gameData.username + " vs " + gameData.opponentname
                              + " - Result of the game: (" + gameData.symbol + gameData.ratingPerGame + ")"
                              + ". Your rating: " + gameData.currentRating 
                              + ". Games you played: " +  gameData.gamesCount);
        }
    }
}