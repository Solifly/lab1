namespace ConsoleApp1;

public class GameResults
{
    public enum States
    {
        Win,
        Lose
    }

    public States GameResult;
    public String username;
    public String opponentname;
    public int ratingPerGame;
    public int currentRating;
    public int gamesCount;
    public int ID;
    public char symbol;
    
    public GameResults(){}

    public GameResults(string username, string opponentname, int ratingPerGame, int currentRating, int gamesCount, int ID, char symbol)
    {
        this.username = username;
        this.opponentname = opponentname;
        this.ratingPerGame = ratingPerGame;
        this.currentRating = currentRating;
        this.gamesCount = gamesCount;
        this.ID = ID;
        this.symbol = symbol;
    }
}