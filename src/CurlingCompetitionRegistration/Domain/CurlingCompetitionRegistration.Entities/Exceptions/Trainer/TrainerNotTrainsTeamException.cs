namespace CurlingCompetitionRegistration.Entities.Exceptions.Trainer;

public class TrainerNotTrainsTeamException(Entities.Trainer trainer, Entities.Team team)
    : Exception($"Trainer {trainer} is not training team {team}")
{
    public Entities.Trainer Trainer { get; } = trainer;
    public Entities.Team Team { get; } = team;
}