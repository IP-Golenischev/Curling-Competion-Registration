

namespace CurlingCompetitionRegistration.Entities.Base;

public interface IEntity<TKey> : IEquatable<IEntity<TKey>> where TKey: struct
{
    TKey Id { get; }
    
}