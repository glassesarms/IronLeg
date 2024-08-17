namespace IronLeg.Domain.Entities
{
  internal abstract class SoftDeletableEntity : Entity
  {
    public DateTimeOffset? DateDeleted { get; set; }
  }
}
