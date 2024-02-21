using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zombie.Migrations
{
    public partial class UpdateSurvivalTimeTyoe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "SurvivalTime",
                table: "RankingBoard",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SurvivalTime",
                table: "RankingBoard",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");
        }
    }
}
