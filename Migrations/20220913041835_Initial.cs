using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodDonationManagementSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "schoolModels",
                columns: table => new
                {
                    DonarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonarName = table.Column<string>(nullable: true),
                    DonarCity = table.Column<string>(nullable: true),
                    DonarAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolModels", x => x.DonarId);
                });

            migrationBuilder.InsertData(
                table: "schoolModels",
                columns: new[] { "DonarId", "DonarAddress", "DonarCity", "DonarName" },
                values: new object[] { 1, "Anjaneya Badavane", "Davangere", "Pavan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schoolModels");
        }
    }
}
