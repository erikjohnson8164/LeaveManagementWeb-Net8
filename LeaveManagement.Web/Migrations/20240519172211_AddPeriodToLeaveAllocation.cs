using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1b30e9a-d2fc-4083-8bff-eeb2d4d80d4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de700119-8823-4dc1-90fc-8c1ae17eeb92", "AQAAAAIAAYagAAAAEKtaDJOE2yW9qSmiTPLxGwNm4AykQMOK/rvO+nUWE6u0ZZA34Jjfnmb59eeDtGwHhw==", "6b3e8370-7913-4064-ba15-470e55dda289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gd8b15cf-52af-4a97-ab4b-824616a0a45f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f2c2ec0-be92-4038-9e49-e2c6bd2f6f68", "AQAAAAIAAYagAAAAEF3J+wnkVxB3cieMBAhPXabwhOswUXpup67B5rF0Wn3ixwBKirG30oa8FIirsYJQag==", "f13928d3-9c69-4626-88af-e201f398d8f3" });
        }
    }
}
