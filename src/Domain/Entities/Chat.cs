using System.ComponentModel.DataAnnotations.Schema;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class Chat :BaseAuditableEntity
{
    [ForeignKey("Users")]
    public Guid? User_id { get; set; }

    [ForeignKey("Room")]
    public Guid? Room_id { get; set; }

    public string text { get; set; }
    public DateTime chat_Create_at { get; set; }

    public virtual Users user { get; set; }
    public virtual Room room { get; set; }
}