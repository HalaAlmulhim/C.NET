using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class AnotherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Weddeings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Weddeings_UserId",
                table: "Weddeings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weddeings_Users_UserId",
                table: "Weddeings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weddeings_Users_UserId",
                table: "Weddeings");

            migrationBuilder.DropIndex(
                name: "IX_Weddeings_UserId",
                table: "Weddeings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Weddeings");
        }
    }
}
