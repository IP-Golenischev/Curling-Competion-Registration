namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionPlace;

public class InvalidCompetitionPlaceException(string place) : FormatException(
    $"Competition name '{place}' is invalid. competition place must contains only letters, digits or whitespaces")
{
    public string CompetitionPlace { get; } = place;
}