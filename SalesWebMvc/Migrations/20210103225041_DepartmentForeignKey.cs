using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departments_Departmentid",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_Departmentid",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "Departmentid",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartmentsId",
                table: "Seller",
                column: "DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departments_DepartmentsId",
                table: "Seller",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departments_DepartmentsId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartmentsId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartmentsId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "Departmentid",
                table: "Seller",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_Departmentid",
                table: "Seller",
                column: "Departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departments_Departmentid",
                table: "Seller",
                column: "Departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
