using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;
public class Donate :BaseAuditableEntity
{
    [ForeignKey("Streamer")]
    public Guid? Streamer_id { get; set; }

    [ForeignKey("Users")]
    public Guid? User_id { get; set; }

    [ForeignKey("Gift")]
    public Guid? Gift_id { get; set; }

    public DateTime Date_Donate { get; set; }  

    public virtual Streamer Streamer { get; set; }
    public virtual Users Users { get; set; }
    public virtual Gift Gift { get; set; }

}
