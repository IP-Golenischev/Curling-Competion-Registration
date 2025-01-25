using CurlingCompetitionRegistration.Common.Enums;
using CurlingCompetitionRegistration.Domain.ValueObjects;
using CurlingCompetitionRegistration.Entities.Base;

namespace CurlingCompetitionRegistration.Entities;

public class Curler : Person
{
    public FullName FullName { get; }
    public BirthDate BirthDate { get; }
    public Sex Gender { get; }
    public Rank Rank { get; }
    public Trainer Trainer { get; }
    

    protected Curler(int id, FullName name, BirthDate birthDate, Sex gender, Rank rank, Trainer trainer) : base(id, name)
    {
        FullName = name ?? throw new ArgumentNullException(nameof(name));
        BirthDate = birthDate ?? throw new ArgumentNullException(nameof(birthDate));
        Gender = gender;
        Rank = rank;
        Trainer = trainer ?? throw new ArgumentNullException(nameof(trainer));
    }

    public Curler( FullName name, BirthDate birthDate, Sex gender, Rank rank, Trainer trainer) : this(0,name, birthDate, gender, rank, trainer)
    {
    }
}