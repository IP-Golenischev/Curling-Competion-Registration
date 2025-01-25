namespace CurlingCompetitionRegistration.Entities.Exceptions.Team;

public class AnotherTrainerOfCurlerException(Entities.Trainer trainer, Curler curler, Entities.Team? team)
    : InvalidOperationException($"Curler {curler} has another trainer {trainer}")
{
    public Entities.Trainer Trainer { get; } = trainer;
    public Curler Curler { get; } = curler;
    public Entities.Team? Team { get; } = team;
}