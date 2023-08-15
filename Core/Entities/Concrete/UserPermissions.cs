using Core.Entities;

namespace Core.Entities.Concrete
{
  public class UserPermissions : IEntity
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int OperationId { get; set; }
  }
}