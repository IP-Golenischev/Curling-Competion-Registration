using System.Numerics;
using CurlingCompetitionRegistration.Domain.ValueObjects.Base;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class FullName(string firstName, string lastName, string? patronymic) : ValueObject, IEquatable<FullName>, IEqualityOperators<FullName, FullName, bool>
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public string? Patronymic { get; } = patronymic;

    public override bool Equals(IValueObject? other)
    {
        if(other is FullName fullName)
            return Equals(fullName);
        return false;
    }

    public static bool operator ==(FullName? left, FullName? right)
    {
        if(left is null && right is null)
            return true;
        if(left is null || right is null)
            return false;
        return left.Equals(right);
    }

    public static bool operator !=(FullName? left, FullName? right) => !(left == right);


    public bool Equals(FullName? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return FirstName == other.FirstName && LastName == other.LastName && Patronymic == other.Patronymic;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((FullName)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName, Patronymic);
    }
}