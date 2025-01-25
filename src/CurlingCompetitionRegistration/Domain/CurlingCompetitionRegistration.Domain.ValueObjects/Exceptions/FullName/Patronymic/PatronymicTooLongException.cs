namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.Patronymic;

public class PatronymicTooLongException(string patronymic)
    : FormatException($"Patronymic length can not be more than twenty characters")
{
    public string Patronymic { get; } = patronymic;
}