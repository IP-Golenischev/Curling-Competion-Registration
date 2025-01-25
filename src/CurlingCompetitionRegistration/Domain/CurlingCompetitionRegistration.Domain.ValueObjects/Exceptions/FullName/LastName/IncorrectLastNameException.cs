namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.LastName;

public class IncorrectLastNameException(string lastName)
    : FormatException($"Last name '{lastName}' is incorrect. Last name must contain only alphabetic characters")
{
    public string LastName { get; } = lastName;
}