using System.Numerics;
using CurlingCompetitionRegistration.Domain.ValueObjects.Base;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.FirstName;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.LastName;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.FullName.Patronymic;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class FullName : ValueObject, IEquatable<FullName>, IEqualityOperators<FullName, FullName, bool>
{
    public string FirstName { get; }
    public string LastName { get; }
    public string? Patronymic { get; }

    public FullName(string firstName, string lastName, string? patronymic = null)
    {
        if (string.IsNullOrWhiteSpace(lastName))
            throw new LastNameNullException();
        if(firstName.Length < 2)
            throw new LastNameTooShortException(lastName);
        if (lastName.Length > 20)
            throw new LastNameTooLongException(lastName);
        
        if (string.IsNullOrWhiteSpace(firstName))
            throw new FirstNameNullException();
        if(firstName.Length < 2)
            throw new FirstNameTooShortException(firstName);
        if (lastName.Length > 20)
            throw new FirstNameTooLongException(firstName);
        
        if(firstName.Any(c => !char.IsLetter(c)))
            throw new IncorrectFirstNameException(firstName);
        
        if(lastName.Any(c => !char.IsLetter(c)))
            throw new IncorrectLastNameException(lastName);
        if (patronymic is not null)
        {
            switch (patronymic.Length)
            {
                case < 2:
                    throw new PatronymicTooShortException(patronymic);
                case > 20:
                    throw new PatronymicTooLongException(firstName);
            }
            if(patronymic.Any(c => !char.IsLetter(c)))
                throw new IncorrectPatronymicException(firstName);
        }
        
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
    }
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

    public override int GetHashCode() => HashCode.Combine(FirstName, LastName, Patronymic);
}