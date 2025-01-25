namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.FirstName;

public class FirstNameTooShortException(string firstName)
    : FormatException("First name length can not be less than two characters")
{
    public string FirstName { get;  } = firstName;
}