using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesBotelho.Migrations
{
    /// <inheritdoc />
    public partial class InsertSnacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Snacks(Name,DescriptionShort,DescriptionLong,Price,ImageThumbnailUrl,ImageUrl,IsFavorite,InStock,CategoryId) VALUES('Cheese Salada','Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 12.50,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',0,1,1)");
            migrationBuilder.Sql("INSERT INTO Snacks(Name,DescriptionShort,DescriptionLong,Price,ImageThumbnailUrl,ImageUrl,IsFavorite,InStock,CategoryId) VALUES('Misto Quente','Pão, presunto, mussarela e tomate','Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.',8.00,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0,1,1)");
            migrationBuilder.Sql("INSERT INTO Snacks(Name,DescriptionShort,DescriptionLong,Price,ImageThumbnailUrl,ImageUrl,IsFavorite,InStock,CategoryId) VALUES('Cheese Burger','Pão, hambúrger, presunto, mussarela e batalha palha','Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha.', 11.00,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',0,1,1)");
            migrationBuilder.Sql("INSERT INTO Snacks(Name,DescriptionShort,DescriptionLong,Price,ImageThumbnailUrl,ImageUrl,IsFavorite,InStock,CategoryId) VALUES('Lanche Natural Peito Peru','Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.',15.00,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',1,1,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Snacks");
        }
    }
}
