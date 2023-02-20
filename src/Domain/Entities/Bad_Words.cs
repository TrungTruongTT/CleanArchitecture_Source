using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities;
public class Bad_Words :BaseAuditableEntity
{

    [Key]
    public Guid? bad_WordsId { get; set; } 
    public string text { get; set; }
}
