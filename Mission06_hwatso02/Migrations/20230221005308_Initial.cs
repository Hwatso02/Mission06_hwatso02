using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_hwatso02.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RatingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.RatingId);
                });

            migrationBuilder.CreateTable(
                name: "collection",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    RatingId = table.Column<int>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collection", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_collection_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_collection_ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "ratings",
                        principalColumn: "RatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Family" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Musical" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Mystery" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Romance" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Rom-Com" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 9, "Sci-Fi" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 10, "Suspense" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 11, "Thriller" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 12, "Other" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 1, "G" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 2, "PG" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 3, "PG-13" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 4, "R" });

            migrationBuilder.InsertData(
                table: "collection",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "RatingId", "Title", "Year" },
                values: new object[] { 2, 6, "Randal Kleiser", false, "Mom", null, 2, "Grease", (ushort)1978 });

            migrationBuilder.InsertData(
                table: "collection",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "RatingId", "Title", "Year" },
                values: new object[] { 1, 11, "Jaume Collet-Serra", false, null, "Amazing Liam Neeson movie", 3, "Non-Stop", (ushort)2014 });

            migrationBuilder.InsertData(
                table: "collection",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "RatingId", "Title", "Year" },
                values: new object[] { 3, 1, "Jaume Collet-Serra", false, "Kara and Dad", null, 3, "The Italian Job", (ushort)2003 });

            migrationBuilder.CreateIndex(
                name: "IX_collection_CategoryId",
                table: "collection",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_collection_RatingId",
                table: "collection",
                column: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "collection");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "ratings");
        }
    }
}
