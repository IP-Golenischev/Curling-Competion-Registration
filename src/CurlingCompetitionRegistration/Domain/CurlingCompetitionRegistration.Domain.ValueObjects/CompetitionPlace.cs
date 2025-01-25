using CurlingCompetitionRegistration.Domain.ValueObjects.Base;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class CompetitionPlace : SimpleValueObject<string>
{
    public CompetitionPlace(string value) : base(value)
    {
        
    }
    
}