namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.Patronymic;

public class PatronymicTooShortException(string patronymic)
    : FormatException("Patronymic length can not be less than two characters")
{
    public string LastName { get;  } = patronymic;
}