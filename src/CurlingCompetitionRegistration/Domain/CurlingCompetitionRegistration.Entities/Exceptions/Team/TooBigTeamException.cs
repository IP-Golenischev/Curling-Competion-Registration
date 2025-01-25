namespace CurlingCompetitionRegistration.Entities.Exceptions.Team;

public class TooBigTeamException() : Exception("Curling team must contain less than 6 curlers");