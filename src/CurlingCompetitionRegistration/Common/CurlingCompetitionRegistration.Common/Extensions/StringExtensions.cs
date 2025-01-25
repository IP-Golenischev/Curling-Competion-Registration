namespace CurlingCompetitionRegistration.Common.Extensions;

public static class StringExtensions
{
    public static bool HasNotCharacterOrNumberOrWhiteSpace(this string value) => value.Any(c => !(char.IsDigit(c) || char.IsWhiteSpace(c) || char.IsLetter(c)));
    
}