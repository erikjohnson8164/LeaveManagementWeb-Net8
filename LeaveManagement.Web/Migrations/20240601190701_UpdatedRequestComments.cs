using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1b30e9a-d2fc-4083-8bff-eeb2d4d80d4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a750d6e0-0660-4173-b64d-0a1b01f337ed", "AQAAAAIAAYagAAAAEITlGheSA6Mjr51+i219Y4yGf6Wqq91m6mvwhL1biSHPykLiW7Gl5KHNSmAtkcLYJA==", "f6f0ea6f-3834-4edd-af02-2477d29abbc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gd8b15cf-52af-4a97-ab4b-824616a0a45f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99e09ca8-20d2-45e4-bd3f-dd7eb6bba105", "AQAAAAIAAYagAAAAEKh1ZZhNiE1AqcNu8TjSnGIC/cV2jbJ1uBGFgnOHquSm7K2zh89+6hqA7YGpYn2TtQ==", "05731f0c-f580-4121-9b36-25430483507a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
