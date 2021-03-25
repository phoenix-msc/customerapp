using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoenixCust.Migrations
{
    public partial class testdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CodeFirstCustomers",
                columns: new[] { "Id", "Busname", "Custcellphone", "Custemailaddress", "Custname", "Password" },
                values: new object[] { 1, "Applacres,Inc.", "812-279-9721", "applacresinc@gmail.com", "Dave Byers", "spring123" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CustomerId", "ProjectName", "Status" },
                values: new object[] { 1, 1, "applacres.net", "quarterly" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CodeFirstCustomers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
