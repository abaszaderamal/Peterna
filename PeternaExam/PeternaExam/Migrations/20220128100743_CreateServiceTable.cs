using Microsoft.EntityFrameworkCore.Migrations;

namespace PeternaExam.Migrations
{
    public partial class CreateServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Info = table.Column<string>(maxLength: 250, nullable: false),
                    Info2 = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Icon", "Info", "Info2", "Title" },
                values: new object[] { 1, "fas fa-desktop", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Sure Quique Menu" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Icon", "Info", "Info2", "Title" },
                values: new object[] { 2, "fas fa-flask", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Sure Quique Menu" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Icon", "Info", "Info2", "Title" },
                values: new object[] { 3, "far fa-credit-card", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Sure Quique Menu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
