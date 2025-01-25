using System.Collections.Immutable;
using CurlingCompetitionRegistration.Common.Enums;
using CurlingCompetitionRegistration.Domain.ValueObjects;
using CurlingCompetitionRegistration.Entities.Base;
using CurlingCompetitionRegistration.Entities.Exceptions.Team;
using CurlingCompetitionRegistration.Entities.Exceptions.Trainer;

namespace CurlingCompetitionRegistration.Entities;

public class Trainer : Person
{
    private readonly ICollection<Curler> _curlers = [];
    private readonly ICollection<Team> _teams = [];
    public IReadOnlyCollection<Curler> Curlers => _curlers.ToImmutableList();
    public IReadOnlyCollection<Team> Teams => _teams.ToImmutableList();
    protected Trainer(int id, FullName name, ICollection<Curler> curlers, ICollection<Team> teams) : base(id, name)
    {
        var res = curlers.All(c => c.Trainer == this);
        if(res is false)
            throw new AnotherTrainerOfCurlerException(this, curlers.First(c => c.Trainer != this), null);
        res = teams.All(c => c.Trainer == this);
        if(res is false)
            throw new TrainerNotTrainsTeamException(this, teams.First(t => t.Trainer != this));
        _curlers = curlers;
        _teams = teams;
        
    }

    public Trainer(FullName name) : base(name)
    {
    }

    public Team CreateTeam(TeamName name, Sex gender, params Curler[]? curlers) => new(name, gender, this, curlers);
    public void AddCurlerToTeam(Curler curler, Team team)
    {
        ValidateCurlerTeam(curler, team);
        team.AddCurler(curler);
    }

    public void RemoveCurlerFromTeam(Curler curler, Team team)
    {
        ValidateCurlerTeam(curler, team);
        team.RemoveCurler(curler);
    }

    public void AddCurler(Curler curler)
    {
        ValidateCurlerTrains(curler);
        _curlers.Add(curler);
    }
    public void RemoveCurler(Curler curler)
    {
        ValidateCurlerTrains(curler);
        _curlers.Remove(curler);
    }

    private void ValidateCurlerTrains(Curler curler)
    {
        if (curler.Trainer != this)
            throw new AnotherTrainerOfCurlerException(this, curler, null);
    }

    private void ValidateCurlerTeam(Curler curler, Team team)
    {
        if (team.Trainer != this)
            throw new TrainerNotTrainsTeamException(this, team);
        if (curler.Trainer != this)
            throw new AnotherTrainerOfCurlerException(this, curler, team);
        
    }
}