using System.Numerics;

namespace CurlingCompetitionRegistration.Entities.Base;

public abstract class EntityBase(int id) : IEntity<int>, IEqualityOperators<EntityBase, EntityBase, bool>
{
    public int Id { get; } = id;

    protected EntityBase() : this(0)
    {
    }

    public bool Equals(EntityBase other) => Equals((object)other);


    public bool Equals(IEntity<int>? other) => other is not null && Equals((object)other);


    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((EntityBase)obj);
    }

    public override int GetHashCode() => Id;


    public static bool operator ==(EntityBase? left, EntityBase? right)
    {
        if(left is null && right is null) 
            return true;
        if(left is null || right is null)
            return false;
        return left.Equals(right);
    }


    public static bool operator !=(EntityBase? left, EntityBase? right) => !(left == right);

}