using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KlassyCafe.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "AboutUss",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AboutUss_VideoId",
                table: "AboutUss",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutUss_Videos_VideoId",
                table: "AboutUss",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "VideoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutUss_Videos_VideoId",
                table: "AboutUss");

            migrationBuilder.DropIndex(
                name: "IX_AboutUss_VideoId",
                table: "AboutUss");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "AboutUss");
        }
    }
}
