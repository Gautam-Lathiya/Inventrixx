using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventrixx.DatabaseConfig.Migrations
{
    /// <inheritdoc />
    public partial class SetEffectiveToAsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "EffectiveTo",
                table: "ProductPrice",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "EffectiveTo",
                table: "ProductPrice",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);
        }

    }
}
