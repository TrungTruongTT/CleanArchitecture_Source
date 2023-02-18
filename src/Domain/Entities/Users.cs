using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Users : BaseAuditableEntity
{
    [Key]
    public Guid? User_id { get; set; }

    public Guid? Chat_id { get; set; } 
    
    public Guid? Donate_id { get; set; }

    public Guid? Playlist_id { get; set; } 

    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public IList<Chat> Chats { get; set; }
    public IList<Playlist> Playlists { get; set; }
    public IList<Donate> Donates { get; set; }

}
