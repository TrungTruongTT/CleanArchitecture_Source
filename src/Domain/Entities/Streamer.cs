using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;
public  class Streamer :BaseAuditableEntity
{
    [Key]
    public Guid? Streamer_id { get; set; }

    public Guid? Audio_id { get; set; }
    public Guid? Donate_id { get; set; }

    public DateTime Create_at { get; set; }
    public string Streamer_name { get; set; }
    public string Describe { get;set; }

    public virtual Donate Donates { get; set; }
    public IList<Audio> Audios { get; set; }
}
