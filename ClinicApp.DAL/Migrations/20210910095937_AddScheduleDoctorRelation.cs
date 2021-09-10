using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicApp.DAL.Migrations
{
    public partial class AddScheduleDoctorRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Doctors_DoktorId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_DoktorId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DoktorId",
                table: "Schedules");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Doctors_DoctorId",
                table: "Schedules",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Doctors_DoctorId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Schedules");

            migrationBuilder.AddColumn<Guid>(
                name: "DoktorId",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoktorId",
                table: "Schedules",
                column: "DoktorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Doctors_DoktorId",
                table: "Schedules",
                column: "DoktorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
