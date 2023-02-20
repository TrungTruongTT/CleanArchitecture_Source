using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Advertisement : BaseAuditableEntity
{
    [Key]
    public Guid? ads_Id { get; set; }
    public string url { get; set; }
}
