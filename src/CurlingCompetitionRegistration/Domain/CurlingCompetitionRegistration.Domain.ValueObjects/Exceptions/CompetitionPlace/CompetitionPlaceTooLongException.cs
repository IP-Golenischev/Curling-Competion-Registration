namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionPlace;

public class CompetitionPlaceTooLongException(string place) : FormatException($"Competition place '{place}' is too long")
{
    public string Place { get; } = place;
}