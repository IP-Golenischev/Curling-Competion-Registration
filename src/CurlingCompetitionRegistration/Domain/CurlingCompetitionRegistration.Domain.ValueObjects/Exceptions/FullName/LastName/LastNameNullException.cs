namespace CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.LastName;

public class LastNameNullException() : NullReferenceException("Last name cannot be null or empty");