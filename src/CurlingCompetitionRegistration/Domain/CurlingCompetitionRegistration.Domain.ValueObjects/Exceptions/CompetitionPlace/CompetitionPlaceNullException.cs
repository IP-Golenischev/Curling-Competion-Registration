namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionPlace;

public class CompetitionPlaceNullException : ArgumentNullException
{
    public CompetitionPlaceNullException(string? competitionPlace) : base(nameof(competitionPlace),"Competition place cannot be null.")
    {
        
    }
}