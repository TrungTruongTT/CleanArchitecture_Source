using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class Gift :BaseAuditableEntity
{
    [Key]
    public Guid? Gift_id { get; set; }

    public Guid? Donate_id { get; set; }
    public string name_Of_Gift { get; set; }
    public double price { get; set; }
    public byte icon { get; set; }
    public int Exp { get;set; }

    public IList<Donate> Donates { get; set; }
}