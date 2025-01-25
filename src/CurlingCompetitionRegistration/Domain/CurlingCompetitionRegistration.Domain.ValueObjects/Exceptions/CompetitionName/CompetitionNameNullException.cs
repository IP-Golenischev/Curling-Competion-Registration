namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionName;

public class CompetitionNameNullException : ArgumentNullException
{
    public CompetitionNameNullException(string? competitionName) : base(nameof(competitionName),"Competition name cannot be null.")
    {
        
    }
}