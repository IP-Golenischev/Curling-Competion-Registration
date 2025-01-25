using CurlingCompetitionRegistration.Domain.ValueObjects;
using CurlingCompetitionRegistration.Entities.Base;

namespace CurlingCompetitionRegistration.Entities;

public class MainJudge : Person
{
    protected MainJudge(int id, FullName name) : base(id, name)
    {
    }

    public MainJudge(FullName name) : base(name)
    {
    }
    
}