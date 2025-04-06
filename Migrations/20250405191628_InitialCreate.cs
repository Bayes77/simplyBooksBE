using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace simplyBooksBE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    First_Name = table.Column<string>(type: "text", nullable: true),
                    Last_Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Author_Id = table.Column<int>(type: "integer", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "Email", "Favorite", "First_Name", "ImageUrl", "Last_Name", "Uid" },
                values: new object[,]
                {
                    { 101, "alice.johnson@email.com", true, "Alice", "https://randomuser.me/api/portraits/women/71.jpg", "Johnson", "A1" },
                    { 102, "benjiman.lee@email.com", false, "Benjamin", "https://randomuser.me/api/portraits/men/74.jpg", "Lee", "A2" },
                    { 103, "carla.martinez@email.com", true, "Carla", "https://randomuser.me/api/portraits/women/8.jpg", "Martinez", "A3" },
                    { 104, "david.roberts@email.com", false, "David", "https://randomuser.me/api/portraits/men/54.jpg", "Roberts", "A4" },
                    { 105, "emma.zhang@email.com", true, "Emma", "https://randomuser.me/api/portraits/women/35.jpg", "Zhang", "A5" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author_Id", "Description", "ImageUrl", "Price", "Sale", "Title", "Uid" },
                values: new object[,]
                {
                    { 201, 101, "The Secret is a best-selling 2006 self-help book by Rhonda Byrne, based on the earlier film of the same name. It is based on the belief of the law of attraction, which claims that thoughts can change a person's life directly.", "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", 10, true, "The Secret", "B1" },
                    { 202, 102, "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. Originally written in Portuguese, it became a widely translated international bestseller.", "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", 15, false, "The Alchemist", "B2" },
                    { 203, 103, "The Power of Now: A Guide to Spiritual Enlightenment is a book by Eckhart Tolle. The book is intended to be a guide for day-to-day living and stresses the importance of living in the present moment and transcending thoughts of the past or future.", "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", 12, true, "The Power of Now", "B3" },
                    { 204, 104, "The 7 Habits of Highly Effective People, first published in 1989, is a business and self help book", "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", 20, false, "The 7 Habits of Highly Effective People", "B4" },
                    { 205, 105, "The Four Agreements: A Practical Guide to Personal Freedom is a self-help book by bestselling author Don Miguel Ruiz with Janet Mills. The book offers a code of personal conduct based on ancient Toltec wisdom that advocates freedom from self-limiting beliefs that may cause suffering and limitation in a person's life.", "https://images-na.ssl-images-amazon.com/images/I/51aOZmIj8LL._SX331_BO1,204,203,200_.jpg", 18, true, "The Four Agreements", "B5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author_Id",
                table: "Books",
                column: "Author_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
