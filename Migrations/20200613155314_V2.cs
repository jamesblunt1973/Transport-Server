using Microsoft.EntityFrameworkCore.Migrations;

namespace Transport_Server.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarService_Cars_CarId",
                table: "CarService");

            migrationBuilder.DropForeignKey(
                name: "FK_CarService_Mechanic_MechanicId",
                table: "CarService");

            migrationBuilder.DropForeignKey(
                name: "FK_CarService_Services_ServiceId",
                table: "CarService");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServicePart_CarService_CarServiceId",
                table: "CarServicePart");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServicePart_Part_PartId",
                table: "CarServicePart");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_Part_PartId",
                table: "Part");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Part",
                table: "Part");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mechanic",
                table: "Mechanic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServicePart",
                table: "CarServicePart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarService",
                table: "CarService");

            migrationBuilder.RenameTable(
                name: "Part",
                newName: "Parts");

            migrationBuilder.RenameTable(
                name: "Mechanic",
                newName: "Mechanics");

            migrationBuilder.RenameTable(
                name: "CarServicePart",
                newName: "CarServiceParts");

            migrationBuilder.RenameTable(
                name: "CarService",
                newName: "CarServices");

            migrationBuilder.RenameIndex(
                name: "IX_Part_PartId",
                table: "Parts",
                newName: "IX_Parts_PartId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServicePart_PartId",
                table: "CarServiceParts",
                newName: "IX_CarServiceParts_PartId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServicePart_CarServiceId",
                table: "CarServiceParts",
                newName: "IX_CarServiceParts_CarServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_CarService_ServiceId",
                table: "CarServices",
                newName: "IX_CarServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_CarService_MechanicId",
                table: "CarServices",
                newName: "IX_CarServices_MechanicId");

            migrationBuilder.RenameIndex(
                name: "IX_CarService_CarId",
                table: "CarServices",
                newName: "IX_CarServices_CarId");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "CarServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MechanicId",
                table: "CarServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "CarServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mechanics",
                table: "Mechanics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServiceParts",
                table: "CarServiceParts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceParts_CarServices_CarServiceId",
                table: "CarServiceParts",
                column: "CarServiceId",
                principalTable: "CarServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServiceParts_Parts_PartId",
                table: "CarServiceParts",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServices_Cars_CarId",
                table: "CarServices",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServices_Mechanics_MechanicId",
                table: "CarServices",
                column: "MechanicId",
                principalTable: "Mechanics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServices_Services_ServiceId",
                table: "CarServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Parts_PartId",
                table: "Parts",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceParts_CarServices_CarServiceId",
                table: "CarServiceParts");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServiceParts_Parts_PartId",
                table: "CarServiceParts");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServices_Cars_CarId",
                table: "CarServices");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServices_Mechanics_MechanicId",
                table: "CarServices");

            migrationBuilder.DropForeignKey(
                name: "FK_CarServices_Services_ServiceId",
                table: "CarServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Parts_PartId",
                table: "Parts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mechanics",
                table: "Mechanics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServiceParts",
                table: "CarServiceParts");

            migrationBuilder.RenameTable(
                name: "Parts",
                newName: "Part");

            migrationBuilder.RenameTable(
                name: "Mechanics",
                newName: "Mechanic");

            migrationBuilder.RenameTable(
                name: "CarServices",
                newName: "CarService");

            migrationBuilder.RenameTable(
                name: "CarServiceParts",
                newName: "CarServicePart");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_PartId",
                table: "Part",
                newName: "IX_Part_PartId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServices_ServiceId",
                table: "CarService",
                newName: "IX_CarService_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServices_MechanicId",
                table: "CarService",
                newName: "IX_CarService_MechanicId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServices_CarId",
                table: "CarService",
                newName: "IX_CarService_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceParts_PartId",
                table: "CarServicePart",
                newName: "IX_CarServicePart_PartId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceParts_CarServiceId",
                table: "CarServicePart",
                newName: "IX_CarServicePart_CarServiceId");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "CarService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MechanicId",
                table: "CarService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "CarService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Part",
                table: "Part",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mechanic",
                table: "Mechanic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarService",
                table: "CarService",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServicePart",
                table: "CarServicePart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarService_Cars_CarId",
                table: "CarService",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarService_Mechanic_MechanicId",
                table: "CarService",
                column: "MechanicId",
                principalTable: "Mechanic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarService_Services_ServiceId",
                table: "CarService",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServicePart_CarService_CarServiceId",
                table: "CarServicePart",
                column: "CarServiceId",
                principalTable: "CarService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarServicePart_Part_PartId",
                table: "CarServicePart",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Part_PartId",
                table: "Part",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
