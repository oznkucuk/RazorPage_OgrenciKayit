using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPage_OgrenciKayit.Migrations
{
    public partial class deneme1 : Migration
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

            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    KursId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kursadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.KursId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Kurs_KursId",
                        column: x => x.KursId,
                        principalTable: "Kurs",
                        principalColumn: "KursId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iletisims_IletisimMesajId",
                table: "Iletisims",
                column: "IletisimMesajId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_KursId",
                table: "Ogrencis",
                column: "KursId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Kurs");
        }
    }
}
