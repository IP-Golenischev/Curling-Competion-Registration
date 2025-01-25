namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions;

public class IncorrectAgeException(int age)
    : Exception($"{age} is incorrect. Age must be more than 7 and less than 99 years old.");