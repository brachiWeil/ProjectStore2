using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.model.Migrations
{
    /// <inheritdoc />
    public partial class wednes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barkode",
                table: "Products",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barkode",
                table: "Products");
        }
    }
}
