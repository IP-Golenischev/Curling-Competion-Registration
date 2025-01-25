using CurlingCompetitionRegistration.Domain.ValueObjects.Base;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class TeamName : SimpleValueObject<string>
{
    public TeamName(string value) : base(value)
    {
    }
}