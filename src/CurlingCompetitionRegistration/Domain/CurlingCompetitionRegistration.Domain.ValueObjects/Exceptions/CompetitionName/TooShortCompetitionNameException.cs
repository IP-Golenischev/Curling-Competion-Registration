namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionName;

public class TooShortCompetitionNameException(string name) : FormatException($"Competition name '{name}' is too short")
{
    public string Name { get; } = name;
}