using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blood",
                columns: table => new
                {
                    bloodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bloodName = table.Column<string>(nullable: true),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blood", x => x.bloodId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    cityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cityName = table.Column<string>(nullable: true),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.cityId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    mId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.mId);
                });

            migrationBuilder.CreateTable(
                name: "MobiLinkRequest",
                columns: table => new
                {
                    mlrId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true),
                    hospitaltreatment = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    bloodId = table.Column<int>(nullable: false),
                    expected_date = table.Column<DateTime>(nullable: false),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobiLinkRequest", x => x.mlrId);
                    table.ForeignKey(
                        name: "FK_MobiLinkRequest_Blood_bloodId",
                        column: x => x.bloodId,
                        principalTable: "Blood",
                        principalColumn: "bloodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    districtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    districtName = table.Column<string>(nullable: true),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false),
                    cityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.districtId);
                    table.ForeignKey(
                        name: "FK_District_City_cityId",
                        column: x => x.cityId,
                        principalTable: "City",
                        principalColumn: "cityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BloodBank",
                columns: table => new
                {
                    bbId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bbName = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    calendar = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    hotline = table.Column<string>(nullable: true),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false),
                    districtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBank", x => x.bbId);
                    table.ForeignKey(
                        name: "FK_BloodBank_District_districtId",
                        column: x => x.districtId,
                        principalTable: "District",
                        principalColumn: "districtId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    donorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    donorName = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    weight = table.Column<float>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    birthday = table.Column<DateTime>(nullable: false),
                    gender = table.Column<bool>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    bloodId = table.Column<int>(nullable: false),
                    districtId = table.Column<int>(nullable: false),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.donorId);
                    table.ForeignKey(
                        name: "FK_Donor_Blood_bloodId",
                        column: x => x.bloodId,
                        principalTable: "Blood",
                        principalColumn: "bloodId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donor_District_districtId",
                        column: x => x.districtId,
                        principalTable: "District",
                        principalColumn: "districtId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BloodStock",
                columns: table => new
                {
                    bloodstockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    quantity = table.Column<float>(nullable: false),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false),
                    bbId = table.Column<int>(nullable: false),
                    bloodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodStock", x => x.bloodstockId);
                    table.ForeignKey(
                        name: "FK_BloodStock_BloodBank_bbId",
                        column: x => x.bbId,
                        principalTable: "BloodBank",
                        principalColumn: "bbId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BloodStock_Blood_bloodId",
                        column: x => x.bloodId,
                        principalTable: "Blood",
                        principalColumn: "bloodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestToBloodBank",
                columns: table => new
                {
                    rtbkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    gender = table.Column<bool>(nullable: false),
                    birthday = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    amount = table.Column<float>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    hospitaltreatment = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    bloodId = table.Column<int>(nullable: false),
                    bbId = table.Column<int>(nullable: false),
                    expected_date = table.Column<DateTime>(nullable: false),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestToBloodBank", x => x.rtbkId);
                    table.ForeignKey(
                        name: "FK_RequestToBloodBank_BloodBank_bbId",
                        column: x => x.bbId,
                        principalTable: "BloodBank",
                        principalColumn: "bbId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequestToBloodBank_Blood_bloodId",
                        column: x => x.bloodId,
                        principalTable: "Blood",
                        principalColumn: "bloodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonationRequest",
                columns: table => new
                {
                    drId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<float>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    donorId = table.Column<int>(nullable: true),
                    bbId = table.Column<int>(nullable: true),
                    expected_date = table.Column<DateTime>(nullable: false),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationRequest", x => x.drId);
                    table.ForeignKey(
                        name: "FK_DonationRequest_BloodBank_bbId",
                        column: x => x.bbId,
                        principalTable: "BloodBank",
                        principalColumn: "bbId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonationRequest_Donor_donorId",
                        column: x => x.donorId,
                        principalTable: "Donor",
                        principalColumn: "donorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestToDonor",
                columns: table => new
                {
                    rtdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    gender = table.Column<bool>(nullable: false),
                    birthday = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    amount = table.Column<float>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    hospitaltreatment = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    donorId = table.Column<int>(nullable: false),
                    expected_date = table.Column<DateTime>(nullable: false),
                    create_at = table.Column<DateTime>(nullable: false),
                    update_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestToDonor", x => x.rtdId);
                    table.ForeignKey(
                        name: "FK_RequestToDonor_Donor_donorId",
                        column: x => x.donorId,
                        principalTable: "Donor",
                        principalColumn: "donorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blood_bloodName",
                table: "Blood",
                column: "bloodName",
                unique: true,
                filter: "[bloodName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BloodBank_bbName",
                table: "BloodBank",
                column: "bbName",
                unique: true,
                filter: "[bbName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BloodBank_districtId",
                table: "BloodBank",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodStock_bbId",
                table: "BloodStock",
                column: "bbId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodStock_bloodId",
                table: "BloodStock",
                column: "bloodId");

            migrationBuilder.CreateIndex(
                name: "IX_City_cityName",
                table: "City",
                column: "cityName",
                unique: true,
                filter: "[cityName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_District_cityId",
                table: "District",
                column: "cityId");

            migrationBuilder.CreateIndex(
                name: "IX_District_districtName",
                table: "District",
                column: "districtName",
                unique: true,
                filter: "[districtName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DonationRequest_bbId",
                table: "DonationRequest",
                column: "bbId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationRequest_donorId",
                table: "DonationRequest",
                column: "donorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_bloodId",
                table: "Donor",
                column: "bloodId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_districtId",
                table: "Donor",
                column: "districtId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_email",
                table: "Donor",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MobiLinkRequest_bloodId",
                table: "MobiLinkRequest",
                column: "bloodId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestToBloodBank_bbId",
                table: "RequestToBloodBank",
                column: "bbId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestToBloodBank_bloodId",
                table: "RequestToBloodBank",
                column: "bloodId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestToDonor_donorId",
                table: "RequestToDonor",
                column: "donorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "BloodStock");

            migrationBuilder.DropTable(
                name: "DonationRequest");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "MobiLinkRequest");

            migrationBuilder.DropTable(
                name: "RequestToBloodBank");

            migrationBuilder.DropTable(
                name: "RequestToDonor");

            migrationBuilder.DropTable(
                name: "BloodBank");

            migrationBuilder.DropTable(
                name: "Donor");

            migrationBuilder.DropTable(
                name: "Blood");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
