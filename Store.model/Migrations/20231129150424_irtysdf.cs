using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.model.Migrations
{
    /// <inheritdoc />
    public partial class irtysdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TZ",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TZ",
                table: "Customers");
        }
    }
}
