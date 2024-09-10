using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicShop.com.Migrations
{
    /// <inheritdoc />
    public partial class Price2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    digitalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vinylPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cdPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price");
        }
    }
}
