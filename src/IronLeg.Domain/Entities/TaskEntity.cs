namespace IronLeg.Domain.Entities
{
  public sealed class TaskEntity
  {
    public required string Title { get; set; }
    public required string Colour { get; set; }
    public Guid? Parent { get; set; }
    public Guid? Skill { get; set; }
    public Guid? Client { get; set; }
  }
}
