namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.TeamName;

public class TeamNameTooLongException(string teamName)
    : FormatException($"Team name length can not be more than twenty characters")
{
    public string TeamName { get; } = teamName;
}