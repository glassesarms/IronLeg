namespace IronLeg.Domain.Entities
{
  public sealed class TaskEntity
  {
    public required string Title { get; set; }
    public required string Colour { get; set; }
    public Guid? ParentId { get; set; }
    public Guid? SkillId { get; set; }
    public Guid? ClientId { get; set; }
  }
}
