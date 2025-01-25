using CurlingCompetitionRegistration.Domain.ValueObjects;
using CurlingCompetitionRegistration.Entities.Base;

namespace CurlingCompetitionRegistration.Entities;

public class Trainer : Person
{
    protected Trainer(int id, FullName name) : base(id, name)
    {
    }

    public Trainer(FullName name) : base(name)
    {
    }
}