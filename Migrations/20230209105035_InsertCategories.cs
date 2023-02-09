using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesBotelho.Migrations
{
    /// <inheritdoc />
    public partial class InsertCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Normal', 'Lanche feito com ingradientes normais')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Natural', 'Lanche feito com ingradientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELTE FROM Categories");
        }
    }
}
