using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiaryMonitoringSystem.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apiaries",
                columns: table => new
                {
                    apiary_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apiary_title = table.Column<string>(maxLength: 50, nullable: false),
                    CurrentAddress = table.Column<string>(nullable: false),
                    Beekeeper = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apiaries", x => x.apiary_id);
                });

            migrationBuilder.CreateTable(
                name: "Bee_hives",
                columns: table => new
                {
                    hive_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hive_number = table.Column<int>(maxLength: 4, nullable: false),
                    apiary_id = table.Column<int>(nullable: true),
                    QueenbeeBreed = table.Column<string>(nullable: true),
                    QueenbeeAge = table.Column<int>(nullable: false),
                    FamilyClass = table.Column<int>(nullable: false),
                    HiveType = table.Column<string>(nullable: true),
                    ImageFile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bee_hives", x => x.hive_id);
                    table.ForeignKey(
                        name: "FK_Bee_hives_Apiaries_apiary_id",
                        column: x => x.apiary_id,
                        principalTable: "Apiaries",
                        principalColumn: "apiary_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Health_statuses",
                columns: table => new
                {
                    health_status_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    hive_id = table.Column<int>(nullable: false),
                    Temperature = table.Column<int>(nullable: false),
                    Humidity = table.Column<int>(nullable: false),
                    MaxIntensityFrequency = table.Column<int>(nullable: false),
                    IntensityOnLow = table.Column<int>(nullable: false),
                    IntensityOnMediate = table.Column<int>(nullable: false),
                    IntensityOnHigh = table.Column<int>(nullable: false),
                    SoundFile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health_statuses", x => x.health_status_id);
                    table.ForeignKey(
                        name: "FK_Health_statuses_Bee_hives_hive_id",
                        column: x => x.hive_id,
                        principalTable: "Bee_hives",
                        principalColumn: "hive_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    inspection_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    hive_id = table.Column<int>(nullable: false),
                    BroodFrames = table.Column<byte>(nullable: true),
                    HoneyFrames = table.Column<byte>(nullable: true),
                    TotalFrames = table.Column<byte>(nullable: false),
                    Swarming = table.Column<bool>(nullable: true),
                    QueenExist = table.Column<bool>(nullable: true),
                    BabyQueensExist = table.Column<bool>(nullable: true),
                    DailyBroodExist = table.Column<bool>(nullable: true),
                    AggressivenessEstimation = table.Column<byte>(nullable: true),
                    BeesFlightEstimation = table.Column<byte>(nullable: true),
                    HoneyFramesRemoved = table.Column<byte>(nullable: false),
                    BroodFramesRemoved = table.Column<byte>(nullable: false),
                    TotalFramesRemoved = table.Column<byte>(nullable: false),
                    EmptyFramesAdded = table.Column<byte>(nullable: false),
                    HoneyFramesAdded = table.Column<byte>(nullable: false),
                    BroodFramesAdded = table.Column<byte>(nullable: false),
                    TotalFramesAdded = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.inspection_id);
                    table.ForeignKey(
                        name: "FK_Inspections_Bee_hives_hive_id",
                        column: x => x.hive_id,
                        principalTable: "Bee_hives",
                        principalColumn: "hive_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bee_hives_apiary_id",
                table: "Bee_hives",
                column: "apiary_id");

            migrationBuilder.CreateIndex(
                name: "IX_Health_statuses_hive_id",
                table: "Health_statuses",
                column: "hive_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_hive_id",
                table: "Inspections",
                column: "hive_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Health_statuses");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "Bee_hives");

            migrationBuilder.DropTable(
                name: "Apiaries");
        }
    }
}
