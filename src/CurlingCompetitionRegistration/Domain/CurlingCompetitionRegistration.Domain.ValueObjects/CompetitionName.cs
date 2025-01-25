using CurlingCompetitionRegistration.Common.Extensions;
using CurlingCompetitionRegistration.Domain.ValueObjects.Base;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionName;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class CompetitionName : SimpleValueObject<string>
{
    public const int MinLength = 10;
    public const int MaxLength = 100;
    
    public CompetitionName(string value) : base(value)
    {
        if(string.IsNullOrWhiteSpace(value))
            throw new CompetitionNameNullException(value);
        switch (value.Length)
        {
            case < MinLength:
                throw new CompetitionNameNullException(value);
            case > MaxLength:
                throw new CompetitionNameTooLongException(value);
        }
        if(value.HasNotCharacterOrNumberOrWhiteSpace())
            throw new InvalidCompetitionNameException(value);
    }
    
}