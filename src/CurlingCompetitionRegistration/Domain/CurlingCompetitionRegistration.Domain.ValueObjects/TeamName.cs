using System.Text.RegularExpressions;
using CurlingCompetitionRegistration.Domain.ValueObjects.Base;
using CurlingCompetitionRegistration.Domain.ValueObjects.Exceptions.TeamName;

namespace CurlingCompetitionRegistration.Domain.ValueObjects;

public partial class TeamName : SimpleValueObject<string>
{
    public const int MinLength = 3;
    public const int MaxLength = 50;
    public const string ValidationExpression = "^[а-яА-ЯёЁ]{1,47}-\\d{1,2}$";
    public TeamName(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new TeamNameNullException();
        switch (value.Length)
        {
            case <MinLength: throw new TeamNameTooShortException(value);
            case >MaxLength: throw new TeamNameTooLongException(value);
        }

        if (!MyRegex().Match(value).Success)
            throw new IncorrectTeamNameException(value);


    }

    [GeneratedRegex(ValidationExpression)]
    private static partial Regex MyRegex();
}