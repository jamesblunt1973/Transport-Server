using Microsoft.EntityFrameworkCore.Migrations;

namespace Transport_Server.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices");

            migrationBuilder.DropIndex(
                name: "IX_CarServices_CarId",
                table: "CarServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServiceParts",
                table: "CarServiceParts");

            migrationBuilder.DropIndex(
                name: "IX_CarServiceParts_CarServiceId",
                table: "CarServiceParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarServices");

            migrationBuilder.DropColumn(
                name: "CarServiceId",
                table: "CarServiceParts");

            migrationBuilder.RenameTable(
                name: "CarServices",
                newName: "VehicleServices");

            migrationBuilder.RenameTable(
                name: "CarServiceParts",
                newName: "VehicleServiceParts");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_CarServices_ServiceId",
                table: "VehicleServices",
                newName: "IX_VehicleServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServices_MechanicId",
                table: "VehicleServices",
                newName: "IX_VehicleServices_MechanicId");

            migrationBuilder.RenameIndex(
                name: "IX_CarServiceParts_PartId",
                table: "VehicleServiceParts",
                newName: "IX_VehicleServiceParts_PartId");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "VehicleServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleServiceId",
                table: "VehicleServiceParts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleServices",
                table: "VehicleServices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleServiceParts",
                table: "VehicleServiceParts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleServices_VehicleId",
                table: "VehicleServices",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleServiceParts_VehicleServiceId",
                table: "VehicleServiceParts",
                column: "VehicleServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleServiceParts_Parts_PartId",
                table: "VehicleServiceParts",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleServiceParts_VehicleServices_VehicleServiceId",
                table: "VehicleServiceParts",
                column: "VehicleServiceId",
                principalTable: "VehicleServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleServices_Mechanics_MechanicId",
                table: "VehicleServices",
                column: "MechanicId",
                principalTable: "Mechanics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleServices_Services_ServiceId",
                table: "VehicleServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleServices_Vehicles_VehicleId",
                table: "VehicleServices",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleServiceParts_Parts_PartId",
                table: "VehicleServiceParts");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleServiceParts_VehicleServices_VehicleServiceId",
                table: "VehicleServiceParts");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleServices_Mechanics_MechanicId",
                table: "VehicleServices");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleServices_Services_ServiceId",
                table: "VehicleServices");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleServices_Vehicles_VehicleId",
                table: "VehicleServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleServices",
                table: "VehicleServices");

            migrationBuilder.DropIndex(
                name: "IX_VehicleServices_VehicleId",
                table: "VehicleServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleServiceParts",
                table: "VehicleServiceParts");

            migrationBuilder.DropIndex(
                name: "IX_VehicleServiceParts_VehicleServiceId",
                table: "VehicleServiceParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "VehicleServices");

            migrationBuilder.DropColumn(
                name: "VehicleServiceId",
                table: "VehicleServiceParts");

            migrationBuilder.RenameTable(
                name: "VehicleServices",
                newName: "CarServices");

            migrationBuilder.RenameTable(
                name: "VehicleServiceParts",
                newName: "CarServiceParts");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Cars");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleServices_ServiceId",
                table: "CarServices",
                newName: "IX_CarServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleServices_MechanicId",
                table: "CarServices",
                newName: "IX_CarServices_MechanicId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleServiceParts_PartId",
                table: "CarServiceParts",
                newName: "IX_CarServiceParts_PartId");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarServiceId",
                table: "CarServiceParts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServiceParts",
                table: "CarServiceParts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CarServices_CarId",
                table: "CarServices",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarServiceParts_CarServiceId",
                table: "CarServiceParts",
                column: "CarServiceId");

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
        }
    }
}
