namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.FirstName;

public class FirstNameTooLongException(string firstName)
    : FormatException($"First name length can not be more than twenty characters")
{
    public string FirstName { get; } = firstName;
}