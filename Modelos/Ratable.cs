namespace BandNamespace.Models;

internal interface IRatable
{
    double AverageRating { get; }
    void AddRating(Rating rating);
}
