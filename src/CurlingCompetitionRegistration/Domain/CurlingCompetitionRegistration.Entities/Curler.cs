using CurlingCompetitionRegistration.Domain.ValueObjects;
using CurlingCompetitionRegistration.Entities.Base;

namespace CurlingCompetitionRegistration.Entities;

public class Curler : Person
{
    protected Curler(int id, FullName name) : base(id, name)
    {
    }

    public Curler(FullName name) : base(name)
    {
    }
}