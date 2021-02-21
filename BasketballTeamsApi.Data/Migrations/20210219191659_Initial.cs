using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketballTeamsApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourtName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    JerseyNumber = table.Column<int>(type: "int", nullable: false),
                    AveragePoints = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    AverageAssist = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    AverageRebound = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Country", "CourtName", "IsDeleted", "Name" },
                values: new object[] { 1, "USA", "Case Center", false, "Golden State Warriors" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Country", "CourtName", "IsDeleted", "Name" },
                values: new object[] { 2, "USA", "Moda Center at the Rose Quarter", false, "Portland Trail Blazers" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "AverageAssist", "AveragePoints", "AverageRebound", "IsDeleted", "JerseyNumber", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, 32, 9.1m, 32.1m, 4.9m, false, 30, "Stephen Curry", 1 },
                    { 2, 31, 7.4m, 27.3m, 6.5m, false, 11, "Klay Thompson", 1 },
                    { 3, 30, 4.2m, 14.5m, 8.7m, false, 23, "Draymond Green", 1 },
                    { 4, 30, 6.1m, 30.1m, 3.9m, false, 0, "Damian Lillard", 2 },
                    { 5, 36, 7.1m, 21.8m, 6.6m, false, 0, "Carmelo Anthony", 2 },
                    { 6, 29, 11.4m, 26.1m, 5.2m, false, 3, "C. J. McCollum", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
