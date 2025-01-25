namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.TeamName;

public class TeamNameNullException() : NullReferenceException("Team name cannot be null or empty");