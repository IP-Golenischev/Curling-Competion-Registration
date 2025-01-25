namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.LastName;

public class LastNameTooLongException(string lastName)
    : FormatException($"Last name length can not be more than twenty characters")
{
    public string LastName { get; } = lastName;
}