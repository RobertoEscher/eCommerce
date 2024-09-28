using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Office.Migrations
{
    public partial class ColaboradorToVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "VeiculoId");

            migrationBuilder.RenameColumn(
                name: "ColaboradoresId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradorId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculoId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataInicioDeVinculo",
                table: "ColaboradorVeiculo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criado",
                value: new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(924), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Nome", "Placa" },
                values: new object[,]
                {
                    { 1, "FIAT - Argo", "ABC-1234" },
                    { 2, "FIAT - Mobi", "DFG-1234" },
                    { 3, "FIAT - Siena", "HIJ-1234" },
                    { 4, "FIAT - Idea", "LMN-1234" },
                    { 5, "FIAT - Toro", "OPQ-1234" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradorId",
                table: "ColaboradorVeiculo",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradorId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DataInicioDeVinculo",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "VeiculosId");

            migrationBuilder.RenameColumn(
                name: "ColaboradorId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradoresId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculosId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo",
                column: "ColaboradoresId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo",
                column: "VeiculosId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
