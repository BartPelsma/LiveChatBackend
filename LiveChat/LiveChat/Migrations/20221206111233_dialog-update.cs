using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveChat_Backend.Migrations
{
    public partial class dialogupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DialogName",
                table: "Dialogs",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DialogName",
                table: "Dialogs");
        }
    }
}
