namespace CurlingCompetitionRegistration.Entities.Exceptions.Team;

public class TeamNotContainsCurlerException : Exception
{
    public Entities.Team Team { get; }
    public Curler Curler { get; }
    public TeamNotContainsCurlerException(Entities.Team team, Curler curler) : base($"Team {team} does not contain curler {curler}")
    {
        Team = team;
        Curler = curler;
    }
}