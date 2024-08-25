namespace IronLeg.Domain.Entities
{
  public abstract class SoftDeletableEntity : Entity
  {
    public DateTimeOffset? DateDeleted { get; set; }
  }
}
