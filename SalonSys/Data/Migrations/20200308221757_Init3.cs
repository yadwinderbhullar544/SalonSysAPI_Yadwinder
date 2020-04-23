using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalonSys.Data.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentMaster_CustomerMaster_CustomerID",
                table: "AppointmentMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentMaster_StaffMaster_StaffID",
                table: "AppointmentMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffMaster",
                table: "StaffMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerMaster",
                table: "CustomerMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentMaster",
                table: "AppointmentMaster");

            migrationBuilder.RenameTable(
                name: "StaffMaster",
                newName: "Staff");

            migrationBuilder.RenameTable(
                name: "CustomerMaster",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "AppointmentMaster",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentMaster_StaffID",
                table: "Appointment",
                newName: "IX_Appointment_StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentMaster_CustomerID",
                table: "Appointment",
                newName: "IX_Appointment_CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customer_CustomerID",
                table: "Appointment",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Staff_StaffID",
                table: "Appointment",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customer_CustomerID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Staff_StaffID",
                table: "Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "StaffMaster");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "CustomerMaster");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "AppointmentMaster");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_StaffID",
                table: "AppointmentMaster",
                newName: "IX_AppointmentMaster_StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_CustomerID",
                table: "AppointmentMaster",
                newName: "IX_AppointmentMaster_CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffMaster",
                table: "StaffMaster",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerMaster",
                table: "CustomerMaster",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentMaster",
                table: "AppointmentMaster",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentMaster_CustomerMaster_CustomerID",
                table: "AppointmentMaster",
                column: "CustomerID",
                principalTable: "CustomerMaster",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentMaster_StaffMaster_StaffID",
                table: "AppointmentMaster",
                column: "StaffID",
                principalTable: "StaffMaster",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
