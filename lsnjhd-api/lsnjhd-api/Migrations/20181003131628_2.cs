using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lsnjhdapi.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Notes",
                newName: "Title");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "TicketTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TicketTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "TicketTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "TicketTemplates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Statuses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Statuses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Statuses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Severities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Severities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Severities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Programs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Programs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Programs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Offices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Offices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Offices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Contents",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Notes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Notes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UpdatedById",
                table: "Notes",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UpdatedById",
                table: "Notes",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UpdatedById",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UpdatedById",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TicketTemplates");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Severities");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Severities");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Severities");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Contents",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Notes",
                newName: "Message");
        }
    }
}
