using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Office.Migrations
{
    public partial class TurmaSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1913), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1908), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 2, 46, 641, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Turma A1" },
                    { 2, "Turma A2" },
                    { 3, "Turma A3" },
                    { 4, "Turma A4" },
                    { 5, "Turma A5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(718), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(716), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 27, 18, 35, 52, 36, DateTimeKind.Unspecified).AddTicks(721), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
