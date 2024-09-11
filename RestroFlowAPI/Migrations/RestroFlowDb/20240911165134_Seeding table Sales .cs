using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
  /// <inheritdoc />
  public partial class SeedingtableSales : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder) {


      migrationBuilder.InsertData(
          table: "Sales",
          columns: new[] { "Id", "PaymentMethodId", "Quantity", "RestaurantId", "RestaurantMenuId", "SaleDate", "TotalAmount" },
          values: new object[,]
          {
                    { new Guid("0bc64787-63d1-4820-b042-55816b6f3f9a"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1318), 192m },
                    { new Guid("2cd54c28-dd79-4866-bd16-8d657f6d028d"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1295), 217.5m },
                    { new Guid("2e8aca7b-3aad-427f-be27-940dca1c557e"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1236), 720m },
                    { new Guid("3e375165-0c1c-4b92-af7c-e7e5462c0af5"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1305), 145.0m },
                    { new Guid("59fd5cfd-912f-4588-a803-7b28eeb83c8f"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1290), 288m },
                    { new Guid("6e172d07-9980-4ba3-b051-2ebb175f49f5"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1337), 264.0m },
                    { new Guid("8bdf2091-54be-42c2-8806-4ac1f33e50b6"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1248), 272m },
                    { new Guid("990bc813-7157-4e28-80b6-ae2911683f6b"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1322), 15.5m },
                    { new Guid("9df343b1-af60-49fc-9aae-b7deb602d187"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1312), 13.5m },
                    { new Guid("a8f70242-8a62-40de-b891-859682124768"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1254), 296.0m },
                    { new Guid("acbbe837-e943-4c50-90b6-476def8ab77d"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1328), 180m },
                    { new Guid("c7c272bf-8dce-4e74-b350-14f1b03aa177"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1333), 448m },
                    { new Guid("cb294caf-d5db-4391-8b35-06088d44f337"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1301), 13.8m },
                    { new Guid("ce3ff72a-42f3-4f62-b013-02750ed2d57a"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1343), 165m },
                    { new Guid("e53735da-a5da-4251-ad3b-419382ed6533"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1243), 42m },
                    { new Guid("efcc7fdb-fb0a-4d58-aa44-3d5fe5525358"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 11, 2, 51, 34, 57, DateTimeKind.Local).AddTicks(1185), 420m }
          });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("0bc64787-63d1-4820-b042-55816b6f3f9a"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("2cd54c28-dd79-4866-bd16-8d657f6d028d"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("2e8aca7b-3aad-427f-be27-940dca1c557e"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("3e375165-0c1c-4b92-af7c-e7e5462c0af5"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("59fd5cfd-912f-4588-a803-7b28eeb83c8f"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("6e172d07-9980-4ba3-b051-2ebb175f49f5"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("8bdf2091-54be-42c2-8806-4ac1f33e50b6"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("990bc813-7157-4e28-80b6-ae2911683f6b"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("9df343b1-af60-49fc-9aae-b7deb602d187"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("a8f70242-8a62-40de-b891-859682124768"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("acbbe837-e943-4c50-90b6-476def8ab77d"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("c7c272bf-8dce-4e74-b350-14f1b03aa177"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("cb294caf-d5db-4391-8b35-06088d44f337"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("ce3ff72a-42f3-4f62-b013-02750ed2d57a"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("e53735da-a5da-4251-ad3b-419382ed6533"));

      migrationBuilder.DeleteData(
          table: "Sales",
          keyColumn: "Id",
          keyValue: new Guid("efcc7fdb-fb0a-4d58-aa44-3d5fe5525358"));

      migrationBuilder.InsertData(
          table: "Sales",
          columns: new[] { "Id", "PaymentMethodId", "Quantity", "RestaurantId", "RestaurantMenuId", "SaleDate", "TotalAmount" },
          values: new object[,]
          {
                    { new Guid("18943588-c0a2-4a19-bb86-50cefb4c1d58"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1079), 181.5m },
                    { new Guid("23f31a6e-e713-4f42-a31c-e2c033756710"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1084), 180m },
                    { new Guid("3b9364a9-a8c1-495b-a92f-5ca6830c0ad8"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(986), 440m },
                    { new Guid("3c14e2cc-e436-4801-a637-e2e59ce9a774"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1004), 296.0m },
                    { new Guid("3c6144f4-73aa-4dea-9f33-c7a7fbb5e67f"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(993), 315m },
                    { new Guid("58f73976-9927-43d8-a8cf-894b955ba95c"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1053), 216.0m },
                    { new Guid("6c5f5378-7d32-4b8f-9b5f-35ae40b02df7"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1069), 20m },
                    { new Guid("7989335d-dc5d-40b6-85a2-af29e83474e8"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1059), 288m },
                    { new Guid("7b484986-9f6e-4b7d-a200-0d5f34cef6ef"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1065), 170.5m },
                    { new Guid("86799410-28ab-49be-8ea0-3cb9bd58d85b"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1012), 16m },
                    { new Guid("8a0341be-aa7e-4c9c-907f-c150299c4115"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(999), 306m },
                    { new Guid("b8bcf013-4764-49b3-93e8-72b2121e55c8"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1022), 82.8m },
                    { new Guid("ba1f39c4-6978-427b-9136-3987ff47a639"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1016), 261.0m },
                    { new Guid("c5f61567-bdea-4a97-b5a1-7e8cd6e99385"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(941), 672m },
                    { new Guid("c9f76d53-d51c-426b-8e40-36739503acf3"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1075), 336m },
                    { new Guid("d1fa1e94-8485-410b-b6ac-9dceb81c5aea"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 10, 2, 42, 45, 229, DateTimeKind.Local).AddTicks(1046), 29.0m }
          });
    }
  }
}
