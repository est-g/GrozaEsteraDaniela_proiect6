using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrozaEsteraDaniela_proiect6.Migrations
{
    public partial class DataNasterii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasterii",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNasterii",
                table: "Student");
        }
    }
}
