using System.Numerics;

namespace CurlingCompetitionRegistration.Domain.ValueObjects.Base;

public abstract class SimpleValueObject<TValue> : ValueObject, IEquatable<TValue>, IEqualityOperators<SimpleValueObject<TValue>, TValue, bool>, IEqualityOperators<SimpleValueObject<TValue>, SimpleValueObject<TValue>, bool>, IEquatable<SimpleValueObject<TValue>>
{
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) 
            return true;
        return obj.GetType() == GetType() && Equals((SimpleValueObject<TValue>)obj);
    }

    public override int GetHashCode() => EqualityComparer<TValue>.Default.GetHashCode(Value ?? throw new NullReferenceException());

    public TValue Value { get; }

    protected SimpleValueObject(TValue value)
    {
        if(value is null)
            throw  new ArgumentNullException(nameof(value));
        Value = value;
    }

    public bool Equals(TValue? other) => other is not null && EqualityComparer<TValue>.Default.Equals(Value, other);

    public static bool operator ==(SimpleValueObject<TValue>? left, TValue? right)
    {
        if(left is null || right is null) 
            return false;
        return left.Equals(right);
        
    }

    public static bool operator !=(SimpleValueObject<TValue>? left, TValue? right) => !(left == right);


    public static bool operator ==(SimpleValueObject<TValue>? left, SimpleValueObject<TValue>? right)
    {
       if (left is null && right is null) 
           return true;
       if(left is null || right is null)
           return false;
       return left.Equals(right);
    }

    public static bool operator !=(SimpleValueObject<TValue>? left, SimpleValueObject<TValue>? right) => !(left == right);


    public bool Equals(SimpleValueObject<TValue>? other)
    {
        if(other is null) 
            return false;
        return ReferenceEquals(this, other) || EqualityComparer<TValue>.Default.Equals(Value, other.Value);
    }
}