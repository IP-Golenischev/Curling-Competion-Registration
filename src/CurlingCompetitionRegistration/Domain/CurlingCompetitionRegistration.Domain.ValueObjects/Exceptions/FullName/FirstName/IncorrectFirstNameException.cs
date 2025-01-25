namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.FirstName;

public class IncorrectFirstNameException(string firstName)
    : FormatException($"First name '{firstName}' is incorrect. First name must contain only alphabetic characters")
{
    public string FirstName { get; } = firstName;
}