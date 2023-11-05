using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Options;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System;
using TeamTracker.Core.Const;

#nullable disable

namespace TeamTracker.EF.Data.Migrations
{
    public partial class SeedingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
        table: "Role",
        columns: new[] { "Id", "Name", "NormalizedName" },
        values: new object[,]
        {
            { "1", AppRoles.CreationAdmin, AppRoles.CreationAdmin.ToUpper()},
            { "2", AppRoles.ModificationAdmin, AppRoles.ModificationAdmin.ToUpper() },
            { "3", AppRoles.ReportAdmin, AppRoles.ReportAdmin.ToUpper() }
        });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
            table: "Role",
            keyColumn: "Id",
            keyValues: new object[] { "1", "2", "3" });
        }
    }
}
