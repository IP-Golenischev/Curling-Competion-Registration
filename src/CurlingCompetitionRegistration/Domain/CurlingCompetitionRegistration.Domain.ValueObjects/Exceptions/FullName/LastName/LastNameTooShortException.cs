namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.LastName;

public class LastNameTooShortException(string lastName)
    : FormatException("Last name length can not be less than two characters")
{
    public string LastName { get;  } = lastName;
}