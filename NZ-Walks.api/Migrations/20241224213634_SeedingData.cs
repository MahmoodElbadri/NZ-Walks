using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZ_Walks.api.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1db32833-700c-46af-8710-28c3f59d42c3"), "Medium" },
                    { new Guid("21f88c58-c1b2-4ffd-8077-52213d8ba026"), "Easy" },
                    { new Guid("b778f9d5-8358-488a-a578-5e04b92ff5b6"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("2730e821-5dd2-450d-94d7-a5368bfc5626"), "NZ-NZL", "New Zealand", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("412982ef-2339-4782-8315-812513403af2"), "SDY", "Sydney", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("6dfb2724-3461-4fec-901f-08cf1e6fc308"), "NSW", "New South Wales", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("756d68e3-d985-4b98-a76a-a26723f85c1f"), "WGN", "Wellington", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("90107d03-9136-4887-8bc0-3e52b5eb0a96"), "QLD", "Queensland", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("a8bea56d-4c53-45d7-9a8e-3301c6fba50d"), "MEL", "Melbourne", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("cb096dd6-4a47-491d-b905-ae8f6bb54b56"), "VIC", "Victoria", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("f1e5872f-cbe6-4a82-af17-e04cc262ad64"), "AKL", "Auckland", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("1db32833-700c-46af-8710-28c3f59d42c3"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("21f88c58-c1b2-4ffd-8077-52213d8ba026"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b778f9d5-8358-488a-a578-5e04b92ff5b6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2730e821-5dd2-450d-94d7-a5368bfc5626"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("412982ef-2339-4782-8315-812513403af2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6dfb2724-3461-4fec-901f-08cf1e6fc308"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("756d68e3-d985-4b98-a76a-a26723f85c1f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("90107d03-9136-4887-8bc0-3e52b5eb0a96"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a8bea56d-4c53-45d7-9a8e-3301c6fba50d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cb096dd6-4a47-491d-b905-ae8f6bb54b56"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f1e5872f-cbe6-4a82-af17-e04cc262ad64"));
        }
    }
}
