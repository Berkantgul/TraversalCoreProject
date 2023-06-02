using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraversalCoreProject.DataAccess.Migrations
{
    public partial class mig_first_feature_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBigImage",
                table: "FirstFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBigImage",
                table: "FirstFeatures");
        }
    }
}
