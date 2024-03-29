﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simple_Pagination_Dotnet.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_products",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category_id = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_products", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 1, "Mobile", "One small reduction of the notch, one giant leap for the iPhone! That's the best description for the most minor iPhone upgrade yet - the Apple iPhone 13.", "Apple iPhone 13", 30000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 2, "Mobile", "Glass front, plastic frame, plastic back 1080 x 2408 pixels, 20:9 ratio (~400 ppi density)", "Samsung Galaxy F42 5G", 25000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 3, "Mobile", "2021, September 30 6.53 inches, 102.9 cm2 (~81.0% screen-to-body ratio) Octa-core (4x2.3 GHz Cortex-A53 & 4x1.8 GHz Cortex-A53)", "Xiaomi Poco C31", 8000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 4, "Mobile", "Qualcomm SM7125 Snapdragon 720G (8 nm)  Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot", "Xiaomi Redmi Note 10 Lite", 10000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 5, "Laptop", "Life is brighter and clearer with Zenbook 14X OLED, the slim, light and compact laptop with a gorgeous 16:10 4K OLED HDR NanoEdge touchscreen that gives you the deepest blacks and the most vivid colours.", "ASUS Zenbook 14X OLED", 45000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 6, "Laptop", "ASUS ExpertBook B7 Flip is an enterprise-level, 5G-enabled premium laptop that’s designed to accelerate your business1. Working on the go is easier than ever with a lightning-fast data", "ASUS ExpertBook B7", 33000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 7, "Laptop", "Turn your creative vision into reality with the ProArt Studiobook 16 studio laptop: it pushes every boundary to give you the effortless creative experience you’ve always wanted, but never thought possible. With a certified color-accurate 16-inch 120 Hz 2.5K IPS", "ProArt Studiobook 16", 53000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 8, "Pc", "Professional Monitor – 27-inch, IPS, WQHD (2560 x 1440), 100% sRGB, 100% Rec. 709, Color Accuracy ΔE < 2, Calman Verified, USB-C, DisplayPort Daisy-chaining, ProArt Preset, ProArt Palette, Ergonomic Stand", "ASUS ProArt Display PA278CV", 38000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 9, "Pc", "With a slim 8.5 mm (0.3-inch) profile and tipping the scales at just 800g (1.76 pounds), the MB169B+ is the world’s slimmest and lightest companion display, ideal for a simple on-the-go dual-monitor setup and mobile presentations.", "Sleek and ultra-portable with a Zen-inspired design", 19000000 });

            migrationBuilder.InsertData(
                table: "tbl_products",
                columns: new[] { "id", "category_id", "description", "name", "price" },
                values: new object[] { 10, "Pc", "ASUS Mini PC PN62 is an ultracompact computer that delivers powerful performance for a wide variety of home and business applications. Featuring the latest 10th Generation Intel® Core™ processors and support for high-speed 2666 MHz DDR4 memory, Mini PC PN62 is ready to take on demanding workloads, yet its diminutive size takes up", "Ultracompact mini PC ", 12000000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_products");
        }
    }
}
