using System.ComponentModel.DataAnnotations.Schema;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class Audio :BaseAuditableEntity
{
    [ForeignKey("Category")]
    public Guid? Category_id { get; set; }
    [ForeignKey("Streamer")]
    public Guid? Streamer_id { get; set; }
    [ForeignKey("Playlist")]
    public Guid? Playlist_id { get; set; }
    public string Url { get; set; }
    //public boolean Like {get; set;}
    //public boolean Displike {get; set;}

    public virtual Streamer Streamer { get; set; }
    public virtual Category Category { get; set; }
    public virtual Playlist Playlists { get; set; }
}