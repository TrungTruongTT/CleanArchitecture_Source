using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PodcastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Categoryid = table.Column<Guid>(name: "Category_id", type: "uniqueidentifier", nullable: false),
                    Roomid = table.Column<Guid>(name: "Room_id", type: "uniqueidentifier", nullable: true),
                    Audioid = table.Column<Guid>(name: "Audio_id", type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Categoryid);
                });

            migrationBuilder.CreateTable(
                name: "Follower",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Streamerid = table.Column<Guid>(name: "Streamer_id", type: "uniqueidentifier", nullable: true),
                    Userid = table.Column<Guid>(name: "User_id", type: "uniqueidentifier", nullable: true),
                    Levelid = table.Column<Guid>(name: "Level_id", type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follower", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gift",
                columns: table => new
                {
                    Giftid = table.Column<Guid>(name: "Gift_id", type: "uniqueidentifier", nullable: false),
                    Donateid = table.Column<Guid>(name: "Donate_id", type: "uniqueidentifier", nullable: true),
                    nameOfGift = table.Column<string>(name: "name_Of_Gift", type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    icon = table.Column<byte>(type: "tinyint", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gift", x => x.Giftid);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Followerid = table.Column<Guid>(name: "Follower_id", type: "uniqueidentifier", nullable: true),
                    Namelevel = table.Column<string>(name: "Name_level", type: "nvarchar(max)", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Streamer",
                columns: table => new
                {
                    Streamerid = table.Column<Guid>(name: "Streamer_id", type: "uniqueidentifier", nullable: false),
                    Audioid = table.Column<Guid>(name: "Audio_id", type: "uniqueidentifier", nullable: true),
                    Donateid = table.Column<Guid>(name: "Donate_id", type: "uniqueidentifier", nullable: true),
                    Createat = table.Column<DateTime>(name: "Create_at", type: "datetime2", nullable: false),
                    Streamername = table.Column<string>(name: "Streamer_name", type: "nvarchar(max)", nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowerId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streamer", x => x.Streamerid);
                    table.ForeignKey(
                        name: "FK_Streamer_Follower_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "Follower",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FollowerLevel",
                columns: table => new
                {
                    FollowerListId = table.Column<int>(type: "int", nullable: false),
                    LevesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowerLevel", x => new { x.FollowerListId, x.LevesId });
                    table.ForeignKey(
                        name: "FK_FollowerLevel_Follower_FollowerListId",
                        column: x => x.FollowerListId,
                        principalTable: "Follower",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowerLevel_Level_LevesId",
                        column: x => x.LevesId,
                        principalTable: "Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Streamerid = table.Column<Guid>(name: "Streamer_id", type: "uniqueidentifier", nullable: true),
                    Categoryid = table.Column<Guid>(name: "Category_id", type: "uniqueidentifier", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Category_Category_id",
                        column: x => x.Categoryid,
                        principalTable: "Category",
                        principalColumn: "Category_id");
                    table.ForeignKey(
                        name: "FK_Room_Streamer_Streamer_id",
                        column: x => x.Streamerid,
                        principalTable: "Streamer",
                        principalColumn: "Streamer_id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Userid = table.Column<Guid>(name: "User_id", type: "uniqueidentifier", nullable: false),
                    Chatid = table.Column<Guid>(name: "Chat_id", type: "uniqueidentifier", nullable: true),
                    Donateid = table.Column<Guid>(name: "Donate_id", type: "uniqueidentifier", nullable: true),
                    Playlistid = table.Column<Guid>(name: "Playlist_id", type: "uniqueidentifier", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowerId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                    table.ForeignKey(
                        name: "FK_Users_Follower_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "Follower",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<Guid>(name: "User_id", type: "uniqueidentifier", nullable: true),
                    Roomid = table.Column<Guid>(name: "Room_id", type: "uniqueidentifier", nullable: true),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chatCreateat = table.Column<DateTime>(name: "chat_Create_at", type: "datetime2", nullable: false),
                    Userid1 = table.Column<Guid>(name: "User_id1", type: "uniqueidentifier", nullable: false),
                    roomId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_Room_roomId",
                        column: x => x.roomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chat_Users_User_id1",
                        column: x => x.Userid1,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Streamerid = table.Column<Guid>(name: "Streamer_id", type: "uniqueidentifier", nullable: true),
                    Userid = table.Column<Guid>(name: "User_id", type: "uniqueidentifier", nullable: true),
                    Giftid = table.Column<Guid>(name: "Gift_id", type: "uniqueidentifier", nullable: true),
                    DateDonate = table.Column<DateTime>(name: "Date_Donate", type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donate_Gift_Gift_id",
                        column: x => x.Giftid,
                        principalTable: "Gift",
                        principalColumn: "Gift_id");
                    table.ForeignKey(
                        name: "FK_Donate_Streamer_Streamer_id",
                        column: x => x.Streamerid,
                        principalTable: "Streamer",
                        principalColumn: "Streamer_id");
                    table.ForeignKey(
                        name: "FK_Donate_Users_User_id",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "User_id");
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<Guid>(name: "User_id", type: "uniqueidentifier", nullable: true),
                    Audioid = table.Column<Guid>(name: "Audio_id", type: "uniqueidentifier", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersUserid = table.Column<Guid>(name: "UsersUser_id", type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlist_Users_UsersUser_id",
                        column: x => x.UsersUserid,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoryid = table.Column<Guid>(name: "Category_id", type: "uniqueidentifier", nullable: true),
                    Streamerid = table.Column<Guid>(name: "Streamer_id", type: "uniqueidentifier", nullable: true),
                    Playlistid = table.Column<Guid>(name: "Playlist_id", type: "uniqueidentifier", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaylistsId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audio_Category_Category_id",
                        column: x => x.Categoryid,
                        principalTable: "Category",
                        principalColumn: "Category_id");
                    table.ForeignKey(
                        name: "FK_Audio_Playlist_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Audio_Streamer_Streamer_id",
                        column: x => x.Streamerid,
                        principalTable: "Streamer",
                        principalColumn: "Streamer_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audio_Category_id",
                table: "Audio",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Audio_PlaylistsId",
                table: "Audio",
                column: "PlaylistsId");

            migrationBuilder.CreateIndex(
                name: "IX_Audio_Streamer_id",
                table: "Audio",
                column: "Streamer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_roomId",
                table: "Chat",
                column: "roomId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_User_id1",
                table: "Chat",
                column: "User_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Donate_Gift_id",
                table: "Donate",
                column: "Gift_id");

            migrationBuilder.CreateIndex(
                name: "IX_Donate_Streamer_id",
                table: "Donate",
                column: "Streamer_id",
                unique: true,
                filter: "[Streamer_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Donate_User_id",
                table: "Donate",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_FollowerLevel_LevesId",
                table: "FollowerLevel",
                column: "LevesId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_UsersUser_id",
                table: "Playlist",
                column: "UsersUser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Category_id",
                table: "Room",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Streamer_id",
                table: "Room",
                column: "Streamer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Streamer_FollowerId",
                table: "Streamer",
                column: "FollowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FollowerId",
                table: "Users",
                column: "FollowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoomId",
                table: "Users",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audio");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Donate");

            migrationBuilder.DropTable(
                name: "FollowerLevel");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "Gift");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Streamer");

            migrationBuilder.DropTable(
                name: "Follower");
        }
    }
}
