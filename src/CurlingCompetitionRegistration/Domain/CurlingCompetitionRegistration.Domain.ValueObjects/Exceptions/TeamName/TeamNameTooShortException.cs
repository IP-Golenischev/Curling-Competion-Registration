namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.TeamName;

public class TeamNameTooShortException(string teamName)
    : FormatException("Team name length can not be less than two characters")
{
    public string TeamName { get;  } = teamName;
}