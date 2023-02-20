using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Audio> Audio { get; }
    DbSet<Category> Category { get; }
    DbSet<Chat> Chat { get; }
    DbSet<Donate> Donate { get; }
    DbSet<Follower> Follower { get; }
    DbSet<Gift> Gift { get; }
    DbSet<Level> Level { get; }
    DbSet<Playlist> Playlist { get; }
    DbSet<Room> Room { get; }
    DbSet<Streamer> Streamer { get; }
    DbSet<Users> Users { get; }


    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
