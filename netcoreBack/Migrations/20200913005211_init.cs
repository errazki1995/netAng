using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoreBack.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tarjetaCredito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titular = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumeroTarjeta = table.Column<string>(type: "varchar(16)", nullable: true),
                    fechaExpiracion = table.Column<string>(type: "varchar(5)", nullable: true),
                    CVV = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarjetaCredito", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tarjetaCredito");
        }
    }
}
