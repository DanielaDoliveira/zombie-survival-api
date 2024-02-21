using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zombie.Migrations
{
    public partial class AddSurvivalTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SurvivalTime",
                table: "RankingBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurvivalTime",
                table: "RankingBoard");
        }
    }
}
