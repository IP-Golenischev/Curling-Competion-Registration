using CurlingCompetitionRegistration.Common.Extensions;
using CurlingCompetitionRegistration.Domain.ValueObjects.Base;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.CompetitionPlace;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public class CompetitionPlace : SimpleValueObject<string>
{
    public const int MinLength = 10;
    public const int MaxLength = 100;
    
    public CompetitionPlace(string value) : base(value)
    {
        if(string.IsNullOrWhiteSpace(value))
            throw new CompetitionPlaceNullException(value);
        switch (value.Length)
        {
            case < MinLength:
                throw new CompetitionPlaceNullException(value);
            case > MaxLength:
                throw new CompetitionPlaceTooLongException(value);
        }
        if(value.HasNotCharacterOrNumberOrWhiteSpace())
            throw new InvalidCompetitionPlaceException(value);
    }
    
}