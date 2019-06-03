using Microsoft.EntityFrameworkCore.Migrations;

namespace boubackend.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendorName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNum = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    WebAddress = table.Column<string>(nullable: true),
                    FacebookPage = table.Column<string>(nullable: true),
                    InstagramPage = table.Column<string>(nullable: true),
                    VendorBio = table.Column<string>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
