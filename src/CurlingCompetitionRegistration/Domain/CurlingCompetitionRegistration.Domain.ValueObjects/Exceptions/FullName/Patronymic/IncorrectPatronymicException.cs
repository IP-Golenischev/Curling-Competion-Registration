namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.Patronymic;

public class IncorrectPatronymicException(string patronymic)
    : FormatException($"Patronymic '{patronymic}' is incorrect. Last name must contain only alphabetic characters")
{
    public string Patronymic { get; } = patronymic;
}