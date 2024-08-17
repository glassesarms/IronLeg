namespace IronLeg.Domain.Entities
{
  public sealed class SkillEntity : SoftDeletableEntity
  {
    public required string Title { get; set; }
    public required string Colour { get; set; }
    public Guid? ParentId { get; set; }
  }
}
