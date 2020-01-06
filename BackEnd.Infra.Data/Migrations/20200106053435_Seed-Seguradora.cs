using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Infra.Data.Migrations
{
    public partial class SeedSeguradora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seguradora",
                columns: new[] { "Id", "Ativo", "Cnpj", "CriadoEm", "Nome" },
                values: new object[,]
                {
                    { 1, true, "24751734000170", new DateTime(2020, 1, 6, 2, 34, 35, 226, DateTimeKind.Local), "Malu e Milena Seguradora" },
                    { 2, true, "76395991000110", new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), "Bruno e Kauê Seguradora" },
                    { 3, true, "42597748000163", new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), "Clarice e Osvaldo Seguradora" },
                    { 4, true, "08141045000198", new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), "Luan e Emanuel Seguradora" },
                    { 5, true, "25934594000139", new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), "Carla e Severino Seguradora" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seguradora",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seguradora",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seguradora",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seguradora",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seguradora",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
