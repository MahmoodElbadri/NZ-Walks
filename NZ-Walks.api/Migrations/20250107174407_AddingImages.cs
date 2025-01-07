using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZ_Walks.api.Migrations
{
    /// <inheritdoc />
    public partial class AddingImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("03000638-01fa-48a8-87a6-cb47c1a9e0fe"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("258f9671-3074-4f7f-956e-1421bfb18cd1"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("6a19689d-d988-47af-8a0e-ba12c1a526ba"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0972b4a0-6008-4b69-835a-3efdc46fd7ec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("279c7ea3-1a5a-4596-b53b-89ae734665b4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5071674f-98be-4748-8adb-ea72a005c658"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("570bcfe1-b4e9-49df-b395-cf6a691aa11e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6a0b6b5d-4236-45cb-8474-57addf3cea64"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("752a5c57-da04-465f-99a6-cd035b40be59"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("75928d5e-77bd-41e0-9152-673622314cb6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d28afb74-5fc4-4845-86d4-b9ab484fb834"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4af3ee71-e255-4a8b-8eca-20c849e572f4"), "Easy" },
                    { new Guid("510377a0-249e-47ce-a628-e11d6b1e7ebf"), "Medium" },
                    { new Guid("c3f412a4-c826-479d-a565-85d265863881"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("10af1ef0-b93e-46db-b062-8ff5e5148c3e"), "SDY", "Sydney", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("2778b2de-bcfc-4c26-bbbd-891cf1dae55a"), "NSW", "New South Wales", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("2a57cc52-6024-4e9b-8e90-53a47279e865"), "MEL", "Melbourne", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("2a76413b-a6a5-4f6b-8475-f557e94ee4e9"), "AKL", "Auckland", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("30a36840-bf78-419a-b94e-858ab4ceec08"), "WGN", "Wellington", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("45a81bbf-3467-4685-a594-a48abb92d22f"), "NZ-NZL", "New Zealand", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("47c3a52c-cea8-4ad0-bce5-fa93f11c4bef"), "VIC", "Victoria", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("879c53f4-1830-485c-8547-50179fba817c"), "QLD", "Queensland", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("4af3ee71-e255-4a8b-8eca-20c849e572f4"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("510377a0-249e-47ce-a628-e11d6b1e7ebf"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("c3f412a4-c826-479d-a565-85d265863881"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("10af1ef0-b93e-46db-b062-8ff5e5148c3e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2778b2de-bcfc-4c26-bbbd-891cf1dae55a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2a57cc52-6024-4e9b-8e90-53a47279e865"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2a76413b-a6a5-4f6b-8475-f557e94ee4e9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("30a36840-bf78-419a-b94e-858ab4ceec08"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("45a81bbf-3467-4685-a594-a48abb92d22f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("47c3a52c-cea8-4ad0-bce5-fa93f11c4bef"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("879c53f4-1830-485c-8547-50179fba817c"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03000638-01fa-48a8-87a6-cb47c1a9e0fe"), "Medium" },
                    { new Guid("258f9671-3074-4f7f-956e-1421bfb18cd1"), "Easy" },
                    { new Guid("6a19689d-d988-47af-8a0e-ba12c1a526ba"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0972b4a0-6008-4b69-835a-3efdc46fd7ec"), "WGN", "Wellington", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("279c7ea3-1a5a-4596-b53b-89ae734665b4"), "VIC", "Victoria", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("5071674f-98be-4748-8adb-ea72a005c658"), "NZ-NZL", "New Zealand", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("570bcfe1-b4e9-49df-b395-cf6a691aa11e"), "QLD", "Queensland", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("6a0b6b5d-4236-45cb-8474-57addf3cea64"), "AKL", "Auckland", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("752a5c57-da04-465f-99a6-cd035b40be59"), "MEL", "Melbourne", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("75928d5e-77bd-41e0-9152-673622314cb6"), "SDY", "Sydney", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
                    { new Guid("d28afb74-5fc4-4845-86d4-b9ab484fb834"), "NSW", "New South Wales", "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" }
                });
        }
    }
}
