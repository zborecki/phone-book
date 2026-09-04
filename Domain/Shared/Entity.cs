namespace Domain.Shared;

public abstract class Entity
{
    private readonly Guid _id = Guid.NewGuid();

    public Guid GetId() => _id;
}