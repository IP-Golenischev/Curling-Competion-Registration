namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionName;

public class CompetitionNameTooLongException(string name) : FormatException($"Competition name '{name}' is too long")
{
    public string Name { get; } = name;
}