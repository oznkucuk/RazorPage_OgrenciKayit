using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPage_OgrenciKayit.Migrations
{
    public partial class yenitablo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    MesajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimMesajId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.MesajId);
                    table.ForeignKey(
                        name: "FK_Iletisims_Iletisims_IletisimMesajId",
                        column: x => x.IletisimMesajId,
                        principalTable: "Iletisims",
                        principalColumn: "MesajId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iletisims_IletisimMesajId",
                table: "Iletisims",
                column: "IletisimMesajId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisims");
        }
    }
}
