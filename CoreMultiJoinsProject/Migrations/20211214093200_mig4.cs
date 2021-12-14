using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMultiJoinsProject.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "states",
                newName: "StateName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "cities",
                newName: "CityName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateName",
                table: "states",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "countries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "cities",
                newName: "Name");
        }
    }
}
