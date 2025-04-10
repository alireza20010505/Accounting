using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class TransectionTypemig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransectionTypeTypeId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TransectionTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransectionTypes", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransectionTypeTypeId",
                table: "Transactions",
                column: "TransectionTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_TransectionTypes_TransectionTypeTypeId",
                table: "Transactions",
                column: "TransectionTypeTypeId",
                principalTable: "TransectionTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_TransectionTypes_TransectionTypeTypeId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "TransectionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_TransectionTypeTypeId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransectionTypeTypeId",
                table: "Transactions");
        }
    }
}
