using CurlingCompetitionRegistration.Domain.ValueObjects.Base;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class BirthDate : SimpleValueObject<DateOnly>
{
    public int Age => CountAge();
    private int CountAge() => (int)Math.Ceiling(DateTime.Now.Subtract(Value.ToDateTime(TimeOnly.MinValue)).TotalDays / 365);

    public BirthDate(DateOnly value) : base(value)
    {
        var age = CountAge();
        if (age is < 7 or >= 99)
            throw new IncorrectAgeException(age);
    }
    
}