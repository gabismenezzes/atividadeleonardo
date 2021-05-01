using Microsoft.EntityFrameworkCore.Migrations;
namespace WebApplication.Migrations
{
    public partial class CampoSobrenomeAdicionado : Migration
        {
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.AddColumn<string>(
                    name: "Sobrenome",
                    table: "Clientes",
                    nullable: true);
            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropColumn(
                    name: "Sobrenome",
                    table: "Clientes");
            }
        }
        
    }
