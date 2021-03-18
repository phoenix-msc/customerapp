using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoenixCust.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeFirstCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Custname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Busname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Custemailaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Custcellphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeFirstCustomers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeFirstCustomers");
        }
    }
}
