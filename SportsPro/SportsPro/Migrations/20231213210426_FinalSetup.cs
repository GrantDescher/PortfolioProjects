using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsPro.Migrations
{
    /// <inheritdoc />
    public partial class FinalSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "AE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "AU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "BR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "CN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "FI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "GL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "GR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "HK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "IE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "IL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "IN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "IS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "JP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "LR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "MX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "MY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "NG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "NZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "PH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "PR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "QA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "SG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "TH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "TR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "UA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "VN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ZW");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "US");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    CustomersCustomerID = table.Column<int>(type: "int", nullable: false),
                    ProductsProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => new { x.CustomersCustomerID, x.ProductsProductID });
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customers_CustomersCustomerID",
                        column: x => x.CustomersCustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Products_ProductsProductID",
                        column: x => x.ProductsProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "Name" },
                values: new object[,]
                {
                    { "A", "United States" },
                    { "B", "Mexico" },
                    { "C", "Canada" },
                    { "D", "United Kingdom" },
                    { "E", "Australia" }
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 1,
                columns: new[] { "CustomerID", "DateClosed", "DateOpened", "Description", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 5, null, new DateTime(2023, 12, 13, 15, 4, 26, 624, DateTimeKind.Local).AddTicks(2164), "Program fails with error code 510, unable to open database.", 2, 4, "Error launching program" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 2,
                columns: new[] { "CustomerID", "DateOpened", "Description", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 2, new DateTime(2023, 12, 13, 15, 4, 26, 624, DateTimeKind.Local).AddTicks(2167), "Program fails with error code 510, unable to open database.", 7, 1, "Could not install" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 3,
                columns: new[] { "CustomerID", "DateClosed", "DateOpened", "Description", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 3, null, new DateTime(2023, 12, 13, 15, 4, 26, 624, DateTimeKind.Local).AddTicks(2171), "Program fails with error code 510, unable to open database.", 1, 3, "Error launching program" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 4,
                columns: new[] { "CustomerID", "DateOpened", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 5, new DateTime(2023, 12, 13, 15, 4, 26, 624, DateTimeKind.Local).AddTicks(2174), 4, 2, "Program keeps crashing" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Name", "ProductCode", "ReleaseDate" },
                values: new object[] { "Tournament Master 1.0", "TRNY10", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "League Scheduler 1.0", "LEAG10", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "League Scheduler Deluxe 1.0", "LEAGD10", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 7.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Draft Manager 1.0", "DRAFT10", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Tournament Master 2.0", "TRNY20", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "Name", "ProductCode", "ReleaseDate" },
                values: new object[] { "Draft Manager 2.0", "DRAFT20", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianID", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { -1, "", "", "" },
                    { 1, "alison@sportsprosoftware.com", "Alison Diaz", "800-555-0443" },
                    { 2, "awilson@sportsprosoftware.com", "Andrew Wilson", "800-555-0449" },
                    { 3, "gfiori@sportsprosoftware.com", "Gina Fiori", "800-555-0459" },
                    { 4, "gunter@sportsprosoftware.com", "Gunter Wendt", "800-555-0400" },
                    { 5, "jason@sportsprosoftware.com", "Jason Lee", "800-555-0444" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "CountryID", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { 1, "123 Spooner Street", "San Francisco", "A", "kanthoni@pge.com", "Kaitlyn", "Anthoni", "970-331-1691", "63141", "California" },
                    { 2, "123 Spooner Street", "Washington", "A", "ania@mma.nidc.com", "Ania", "Irvin", "970-331-1691", "63141", "California" },
                    { 3, "123 Spooner Street", "Mission Viejo", "B", "", "Gonzalo", "Keeton", "970-331-1691", "63141", "California" },
                    { 4, "123 Spooner Street", "Sacramento", "A", "amauro@yahoo.org", "Anton", "Mauro", "970-331-1691", "63141", "California" },
                    { 5, "123 Spooner Street", "Fresno", "A", "kmayte@fresno.ca.gov", "Kendall", "Mayte", "970-331-1691", "63141", "California" },
                    { 6, "123 Spooner Street", "Los Angeles", "A", "kenzie@mma.jobtrak.com", "Kenzie", "Quinn", "970-331-1691", "63141", "California" },
                    { 7, "123 Spooner Street", "Fresno", "A", "marvin@expedata.com", "Marvin", "Quintin", "", "63141", "California" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductsProductID",
                table: "CustomerProduct",
                column: "ProductsProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "D");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "E");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "B");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "Name" },
                values: new object[,]
                {
                    { "AE", "United Arab Emirates" },
                    { "AT", "Austria" },
                    { "AU", "Australia" },
                    { "BE", "Belgium" },
                    { "BR", "Brazil" },
                    { "CA", "Canada" },
                    { "CH", "Switzerland" },
                    { "CN", "China" },
                    { "DK", "Denmark" },
                    { "ES", "Spain" },
                    { "FI", "Finland" },
                    { "FR", "France" },
                    { "GB", "United Kingdom" },
                    { "GL", "Greenland" },
                    { "GR", "Greece" },
                    { "HK", "Hong Kong" },
                    { "IE", "Ireland" },
                    { "IL", "Israel" },
                    { "IN", "India" },
                    { "IS", "Iceland" },
                    { "IT", "Italy" },
                    { "JP", "Japan" },
                    { "LR", "Liberia" },
                    { "MX", "Mexico" },
                    { "MY", "Malaysia" },
                    { "NG", "Nigeria" },
                    { "NL", "Netherlands" },
                    { "NZ", "New Zealand" },
                    { "PH", "Philippines" },
                    { "PR", "Puerto Rico" },
                    { "PT", "Portugal" },
                    { "QA", "Qatar" },
                    { "SE", "Sweden" },
                    { "SG", "Singapore" },
                    { "TH", "Thailand" },
                    { "TR", "Turkey" },
                    { "UA", "Ukraine" },
                    { "US", "United States" },
                    { "VN", "Vietnam" },
                    { "ZW", "Zimbabwe" }
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 1,
                columns: new[] { "CustomerID", "DateClosed", "DateOpened", "Description", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 1010, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Media appears to be bad.", 1, 11, "Could not install" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 2,
                columns: new[] { "CustomerID", "DateOpened", "Description", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 1002, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Received error message 415 while trying to import data from previous version.", 4, 14, "Error importing data" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 3,
                columns: new[] { "CustomerID", "DateClosed", "DateOpened", "Description", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 1015, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Setup failed with code 104.", 6, 15, "Could not install" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentID",
                keyValue: 4,
                columns: new[] { "CustomerID", "DateOpened", "ProductID", "TechnicianID", "Title" },
                values: new object[] { 1010, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "Error launching program" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Name", "ProductCode", "ReleaseDate" },
                values: new object[] { "Draft Manager 1.0", "DRAFT10", new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Draft Manager 2.0", "DRAFT20", new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "League Scheduler 1.0", "LEAG10", new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "League Scheduler Deluxe 1.0", "LEAGD10", new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Name", "ProductCode", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Tournament Master 1.0", "TRNY10", new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "Name", "ProductCode", "ReleaseDate" },
                values: new object[] { "Tournament Master 2.0", "TRNY20", new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianID", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 11, "alison@sportsprosoftware.com", "Alison Diaz", "800-555-0443" },
                    { 12, "jason@sportsprosoftware.com", "Jason Lee", "800-555-0444" },
                    { 13, "awilson@sportsprosoftware.com", "Andrew Wilson", "800-555-0449" },
                    { 14, "gunter@sportsprosoftware.com", "Gunter Wendt", "800-555-0400" },
                    { 15, "gfiori@sportsprosoftware.com", "Gina Fiori", "800-555-0459" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "CountryID", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { 1002, "PO Box 96621", "Washington", "US", "ania@mma.nidc.com", "Ania", "Irvin", "(301) 555-8950", "20090", "DC" },
                    { 1004, "1990 Westwood Blvd Ste 260", "Los Angeles", "US", "kenzie@mma.jobtrak.com", "Kenzie", "Quinn", "(800) 555-8725", "90025", "CA" },
                    { 1006, "3255 Ramos Cir", "Sacramento", "US", "amauro@yahoo.org", "Anton", "Mauro", "(916) 555-6670", "95827", "CA" },
                    { 1008, "Box 52001", "San Francisco", "US", "kanthoni@pge.com", "Kaitlyn", "Anthoni", "(800) 555-6081", "94152", "CA" },
                    { 1010, "PO Box 2069", "Fresno", "US", "kmayte@fresno.ca.gov", "Kendall", "Mayte", "(559) 555-9999", "93718", "CA" },
                    { 1012, "4420 N. First Street, Suite 108", "Fresno", "US", "marvin@expedata.com", "Marvin", "Quintin", "(559) 555-9586", "93726", "CA" },
                    { 1015, "27371 Valderas", "Mission Viejo", "US", "", "Gonzalo", "Keeton", "(214) 555-3647", "92691", "CA" }
                });
        }
    }
}
