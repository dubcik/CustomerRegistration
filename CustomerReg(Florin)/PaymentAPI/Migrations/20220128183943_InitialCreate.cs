using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerRegFlorin.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    customerWebsite = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    customerEmail = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    customerPhone = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    addressStreet = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    addressNumber = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    addressCity = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    addressPostcode = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    addressCountry = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    addressStreet2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    addressNumber2 = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    addressPostcode2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    addressCity2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    addressCountry2 = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
