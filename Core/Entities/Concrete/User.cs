using System.Data.Common;
using Core.Entities;

namespace Core.Entities.Concrete
{
public class User:IEntity
{
  public int Id { get; set; }
  public string? FirstName { get; set;}
  public string? LastName { get; set; }
  public string? Email { get; set; }
  public byte[] PasswordHash { get; set; }
  public byte[] PasswordSalt { get; set; }
  public string? Mobile { get; set; }
  public string? Avatar { get; set; }
  public bool Verified { get; set; }
  public bool IsActive { get; set; }
  public DateTime Created_at { get; set; }
  public DateTime Updated_at { get; set; }

}
}