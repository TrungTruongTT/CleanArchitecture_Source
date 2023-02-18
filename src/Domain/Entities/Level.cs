using System.ComponentModel.DataAnnotations.Schema;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class Level :BaseAuditableEntity
{
    public Guid? Follower_id { get; set; }
    public string Name_level { get; set; }
    public int Exp { get; set; }
    public IList<Follower> FollowerList { get; set;}
}