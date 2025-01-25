using System.Numerics;

namespace CurlingCompetitionRegistration.Domain.ValueObjects.Base;

public abstract class ValueObject : IValueObject
{
    public abstract bool Equals(IValueObject? other);
}