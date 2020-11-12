using Microsoft.EntityFrameworkCore.Migrations;

namespace TuitionsOnline.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeachersFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    YearOfBirth = table.Column<int>(type: "int", nullable: false),
                    ResidentialCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidentialPinCode = table.Column<int>(type: "int", nullable: false),
                    Graduate = table.Column<bool>(type: "bit", nullable: false),
                    GraduateField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostGraduate = table.Column<bool>(type: "bit", nullable: false),
                    PostGraduateField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctorate = table.Column<bool>(type: "bit", nullable: false),
                    DoctrateField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceInYears = table.Column<int>(type: "int", nullable: false),
                    RatePerClassInRupees = table.Column<int>(type: "int", nullable: false),
                    SubjectYouWishToTeach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefferedLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadYourIdentificationDocument = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
