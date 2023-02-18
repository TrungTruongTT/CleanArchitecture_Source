using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;
public class Category :BaseAuditableEntity
{
    [Key]
    public Guid Category_id { get; set; }

    public Guid? Room_id { get; set; }
    public Guid? Audio_id { get; set; }

    public string Name { get; set; }

    public IList<Room> Rooms { get; set; }
    public IList<Audio> Audios { get; set; }
}
