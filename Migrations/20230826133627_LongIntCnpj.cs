using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupplierRegistrationContext.Migrations
{
    /// <inheritdoc />
    public partial class LongIntCnpj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CNPJ",
                table: "Suppliers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CEP",
                table: "Suppliers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CNPJ",
                table: "Suppliers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CEP",
                table: "Suppliers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
