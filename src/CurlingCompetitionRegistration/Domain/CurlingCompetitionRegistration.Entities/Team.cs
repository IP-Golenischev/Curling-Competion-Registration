using System.Collections.Immutable;
using CurlingCompetitionRegistration.Common.Enums;
using CurlingCompetitionRegistration.Domain.ValueObjects;
using CurlingCompetitionRegistration.Entities.Base;
using CurlingCompetitionRegistration.Entities.Exceptions.Team;

namespace CurlingCompetitionRegistration.Entities;
/// <summary>
/// Represents team in classic curling(men or women)
/// </summary>
public class Team : EntityBase
{
    private static void ValidateTeam(ICollection<Curler> team, Sex gender, Trainer trainer)
    {
        switch (team.Count)
        {
            case <= 3:
                throw new TooShortTeamException();
            case > 5:
                throw new TooBigTeamException();
        }

        var curler = team.FirstOrDefault(c => c.Gender != gender);
        var same = team.All(c => c.Trainer == trainer);
        if(same is false)
            throw new AnotherTrainerOfCurlerException(trainer, team.First(c => c.Trainer != trainer), null);
        if (curler is not null)
            throw new InvalidTeamCompositionException();
    }
    public TeamName Name { get; }
    public IReadOnlyCollection<Curler> Curlers => _curlers.ToImmutableList();
    private readonly ICollection<Curler> _curlers = [];
    public Sex Gender { get; }
    public Trainer Trainer { get; }

    protected Team(int id, TeamName name, Sex gender, Trainer trainer, params Curler[]? curlers) : base(id)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Gender = gender;
        Trainer = trainer ?? throw new ArgumentNullException(nameof(trainer));
        if (curlers is null) 
            return;
        ValidateTeam(curlers, gender, trainer);
        _curlers = curlers;

    }

    public Team(TeamName name, Sex gender, Trainer trainer, params Curler[]? curlers) : this(0, name, gender, trainer, curlers)
    {
        
    }

    public Team(TeamName name, Sex gender, Trainer trainer) : this(0, name, gender, trainer)
    {
        
    }

    internal void AddCurler(Curler curler)
    {
        if(curler.Gender != Gender)
            throw new InvalidTeamCompositionException();
        if(_curlers.Count >= 5)
            throw new TooBigTeamException();
        if (curler.Trainer != Trainer)
            throw new AnotherTrainerOfCurlerException(Trainer, curler, this);
        _curlers.Add(curler);
    }

    internal void RemoveCurler(Curler curler)
    {
        if (_curlers.Count < 1)
            throw new EmptyTeamException();
        if (!Curlers.Contains(curler))
            throw new TeamNotContainsCurlerException(this, curler);
        _curlers.Remove(curler);
    }
    public override string ToString() => Name.Value;
}