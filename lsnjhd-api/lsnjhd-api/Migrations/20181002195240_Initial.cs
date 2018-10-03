using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lsnjhdapi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Severities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Severities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProgramId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TemplateId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketTypes_TicketTemplates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TicketTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProgramId = table.Column<Guid>(nullable: true),
                    OfficeId = table.Column<Guid>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedById = table.Column<Guid>(nullable: true),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    CompletedById = table.Column<Guid>(nullable: true),
                    Complete = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Completed = table.Column<DateTime>(nullable: false),
                    TicketTemplateId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_CompletedById",
                        column: x => x.CompletedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_TicketTemplates_TicketTemplateId",
                        column: x => x.TicketTemplateId,
                        principalTable: "TicketTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProgramId = table.Column<Guid>(nullable: true),
                    OfficeId = table.Column<Guid>(nullable: true),
                    EndUserId = table.Column<Guid>(nullable: true),
                    TicketTypeId = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    StatusId = table.Column<Guid>(nullable: true),
                    SeverityId = table.Column<Guid>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    Closed = table.Column<DateTime>(nullable: false),
                    ClosedById = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_ClosedById",
                        column: x => x.ClosedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_EndUserId",
                        column: x => x.EndUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Severities_SeverityId",
                        column: x => x.SeverityId,
                        principalTable: "Severities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketTypes_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "TicketTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    TaskId = table.Column<Guid>(nullable: true),
                    TicketId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    TicketId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_TaskId",
                table: "Events",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TicketId",
                table: "Events",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CreatedById",
                table: "Notes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_TicketId",
                table: "Notes",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_ProgramId",
                table: "Offices",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CompletedById",
                table: "Tasks",
                column: "CompletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedById",
                table: "Tasks",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TicketTemplateId",
                table: "Tasks",
                column: "TicketTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UpdatedById",
                table: "Tasks",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClosedById",
                table: "Tickets",
                column: "ClosedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CreatedById",
                table: "Tickets",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EndUserId",
                table: "Tickets",
                column: "EndUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OfficeId",
                table: "Tickets",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProgramId",
                table: "Tickets",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SeverityId",
                table: "Tickets",
                column: "SeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketTypeId",
                table: "Tickets",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UpdatedById",
                table: "Tickets",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TicketTypes_TemplateId",
                table: "TicketTypes",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OfficeId",
                table: "Users",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProgramId",
                table: "Users",
                column: "ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Severities");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TicketTypes");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "TicketTemplates");

            migrationBuilder.DropTable(
                name: "Programs");
        }
    }
}
