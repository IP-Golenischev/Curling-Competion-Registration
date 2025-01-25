namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionPlace;

public class TooShortCompetitionPlaceException(string place) : FormatException($"Competition place '{place}' is too short")
{
    public string Name { get; } = place;
}