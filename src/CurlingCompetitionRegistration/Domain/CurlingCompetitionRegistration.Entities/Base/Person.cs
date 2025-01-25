using CurlingCompetitionRegistration.Domain.ValueObjects;

namespace CurlingCompetitionRegistration.Entities.Base;

public class Person : EntityBase
{
    public FullName Name { get; }

    protected Person(int id, FullName name)
    {
        Name = name;
    }

    public Person(FullName name) : this(0, name)
    {
        
    }
    
}