using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Origi.Migrations
{
    /// <inheritdoc />
    public partial class ori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id_Admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login_Admin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id_Admin);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id_Service = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Service = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Emloyee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id_Service);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id_client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone_cleint = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Url_client = table.Column<string>(type: "nvarchar(max)", nullable: true)
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id_client);
                   
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id_Request = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                  
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Name_client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url_client = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id_Request);
                    table.ForeignKey(
                        name: "FK_Requests_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id_client",
                        onDelete: ReferentialAction.Cascade);
                    
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ClientId",
                table: "Requests",
                column: "ClientId");

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
