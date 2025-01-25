namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.TeamName;

public class IncorrectTeamNameException(string teamName)
    : FormatException($"Last name '{teamName}' is incorrect. Team name must contain only alphabetic characters")
{
    public string TeamName { get; } = teamName;
}