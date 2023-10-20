namespace BandNamespace.Models;

internal class Rating
{
    public Rating(int score)
    {
        Score = score;
    }

    public int Score { get; }

    public static Rating Parse(string text)
    {
        int score = int.Parse(text);
        return new Rating(score);
    }
}
