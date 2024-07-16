using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1b30e9a-d2fc-4083-8bff-eeb2d4d80d4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22cec9f2-af13-42b1-bbcb-b1598cdb804d", "AQAAAAIAAYagAAAAEPzRA4wRy7ArdA3cpq8zpVSN0faLCBn0kF4Mn1MUjwH4S0JXlL2cZ1CnSXLUsDIo3g==", "fb2aa396-3bda-45f8-8b08-0bd77bcaf685" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gd8b15cf-52af-4a97-ab4b-824616a0a45f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "984db74e-eec8-45b5-af24-85ccf89281ac", "AQAAAAIAAYagAAAAEE3k63DtO9H5pMGKO3DDBhzy/wYa0+lo4umTNX1ZfoKtLgG+giHXqW3Y2AJQ++YeNA==", "2403df5f-6589-43d5-8c1f-c860233b6e27" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1b30e9a-d2fc-4083-8bff-eeb2d4d80d4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c6eff83-5c95-4947-94bc-abab1d63f155", "AQAAAAIAAYagAAAAEEOGDeXec31iJ6S+eKdNrMg/W/+cUl4s+YSQ0yanDn2efAWZe3gpgEH+WsgHAP9D0w==", "aca0bb07-afdf-440d-894b-a624799ae054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gd8b15cf-52af-4a97-ab4b-824616a0a45f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "213b520b-fd9a-466f-9fe6-1176c017bd9a", "AQAAAAIAAYagAAAAEKKUOhX9j+m97yWZqlcShZLWvFfc4lWYfoTJJHgX2sVFgiQxlaUBlWmqFZcJ520WZQ==", "e6c07927-c773-4dd8-b5a5-2bef00638c42" });
        }
    }
}
