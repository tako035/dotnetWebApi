using Core.Entities;

namespace Core.Entities.Concrete

{
  public class UserOperations : IEntity
  {
    public int Id { get; set; }
    public string? Name { get; set; }
  }
}