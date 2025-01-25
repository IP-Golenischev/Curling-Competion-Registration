namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionName;

public class InvalidCompetitionNameException(string name) : FormatException(
    $"Competition name '{name}' is invalid. competition name must contains only letters, digits or whitespaces")
{
    public string CompetitionName { get; } = name;
}