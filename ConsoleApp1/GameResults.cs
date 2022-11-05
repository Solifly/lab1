namespace ConsoleApp1;

public class GameResults
{
    public enum States
    {
        Win,
        Lose
    }
    
    public readonly string username;
    public readonly string opponentName;
    public readonly int ratingPerGame;
    public readonly int currentRating;
    public readonly int gamesCount;
    public readonly int id;
    public readonly char symbol;

    public GameResults(string username, string opponentName, int ratingPerGame, int currentRating, int gamesCount, int id, char symbol)
    {
        this.username = username;
        this.opponentName = opponentName;
        this.ratingPerGame = ratingPerGame;
        this.currentRating = currentRating;
        this.gamesCount = gamesCount;
        this.id = id;
        this.symbol = symbol;
    }
}