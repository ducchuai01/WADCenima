using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WADCenima.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    MovieName = table.Column<string>(maxLength: 100, nullable: true),
                    MovieTrailer = table.Column<string>(nullable: true),
                    MovieCast = table.Column<string>(nullable: true),
                    MovieDirectors = table.Column<string>(maxLength: 100, nullable: true),
                    MovieCountry = table.Column<string>(maxLength: 100, nullable: true),
                    MovieWarning = table.Column<string>(maxLength: 100, nullable: true),
                    MovieTime = table.Column<int>(nullable: false),
                    MoviePoster = table.Column<string>(nullable: true),
                    PremiereDate = table.Column<DateTime>(nullable: false),
                    MovieDescription = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    NameRole = table.Column<string>(maxLength: 50, nullable: true),
                    RoleEnum = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    IdentityCard = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    UserName = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    RoleId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId1",
                table: "User",
                column: "RoleId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
