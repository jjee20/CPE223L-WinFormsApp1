using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aaf49b6b-7976-417c-8d6f-a21df27065fa", 0, "2ab2439d-cf98-4c0e-98bb-64f0f3099ca9", "admin@example.com", false, null, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEFIwrw5g5CYmm1+mPWMQicdyPllfvSHS+kIspG+y8hzNcxHFtrSEpD4NV4dN/X3QEg==", null, false, "a3ee3653-3b53-412b-bd2e-cbc19fec2329", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaf49b6b-7976-417c-8d6f-a21df27065fa");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "a6bef0f6-bbf4-4635-a6dd-454d97a33744", "admin@example.com", false, null, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEN9HL7s9pg/unpaxzKcrWwm0M/ePKyLaJAe6lyGPrNHJPOIs25z3vCQacDgqxTGRbA==", null, false, "f69bf0b0-3471-481a-a76a-13ca3f81abed", false, "admin" });
        }
    }
}
