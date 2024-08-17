namespace IronLeg.Domain.Entities
{
  public sealed class TaskEntity : SoftDeletableEntity
  {
    public required string Title { get; set; }
    // Todo: create task status enum
    public int Status { get; set; }
    public required string Colour { get; set; }
    public Guid? ParentId { get; set; }
    public Guid? SkillId { get; set; }
    public Guid? SubjectId { get; set; }
  }
}
