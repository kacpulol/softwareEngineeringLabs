using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB.Migrations
{
    public partial class initupdatedcars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "UserId1",
                table: "Cars",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId1",
                table: "Cars",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AbpUsers_UserId1",
                table: "Cars",
                column: "UserId1",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AbpUsers_UserId1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_UserId1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Cars");
        }
    }
}
