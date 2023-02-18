using System.ComponentModel.DataAnnotations.Schema;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class Playlist :BaseAuditableEntity
{
    [ForeignKey("User")]
    public Guid? User_id { get; set; }
    public Guid? Audio_id { get; set; }


    public string title { get; set; }


    public virtual Users Users { get; set; }
    public IList< Audio> Audios { get; set; }  
}