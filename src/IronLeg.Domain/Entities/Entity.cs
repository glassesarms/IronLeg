namespace IronLeg.Domain.Entities
{
  internal abstract class Entity
  {
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset DateModified { get; set; }
  }
}
