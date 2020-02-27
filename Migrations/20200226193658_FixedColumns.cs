using Microsoft.EntityFrameworkCore.Migrations;

namespace Plant.Migrations
{
    public partial class FixedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Plant");

            migrationBuilder.AlterColumn<string>(
                name: "WaterNeeded",
                table: "Plant",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "LightNeeded",
                table: "Plant",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Plant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Species",
                table: "Plant");

            migrationBuilder.AlterColumn<bool>(
                name: "WaterNeeded",
                table: "Plant",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LightNeeded",
                table: "Plant",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Plant",
                type: "text",
                nullable: true);
        }
    }
}
