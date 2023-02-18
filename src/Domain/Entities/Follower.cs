using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;
public class Follower :BaseAuditableEntity
{
    [ForeignKey("Streamer")]
    public Guid? Streamer_id { get; set; }
    [ForeignKey("Users")]
    public Guid? User_id { get; set; }
    [ForeignKey("Level")]
    public Guid? Level_id { get; set; } 

    public IList<Streamer> Streamers { get; set; } 
    public IList<Users> Userss { get; set; }
    public IList<Level> Leves { get; set; }
}
