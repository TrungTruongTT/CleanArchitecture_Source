using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;
public class Room : BaseAuditableEntity
{
    [ForeignKey("Streamer")]
    public Guid? Streamer_id { get; set; }

    [ForeignKey("Category")]
    public Guid? Category_id { get; set; }

    public string url { get; set; }
    public string title { get; set; }
    public string detail { get;set; }
   
    public IList<Users> Users { get; set; }
    public IList<Chat> Chats { get; set; }
    public virtual Category Category { get; set; }
    public virtual Streamer Streamer { get; set; }

}
