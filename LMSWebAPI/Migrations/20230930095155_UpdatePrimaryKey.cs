using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_course",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNo = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    CourseDate = table.Column<DateTime>(type: "date", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseImageURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sdate = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    suser = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    edate = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    euser = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CourseStatus = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ename = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    eStatus = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    accountType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    eInactive = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    a = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    b = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblcourse_category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CategoryName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    sdate = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    suser = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    edate = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    euser = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    status = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblcourse_details",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CourseCode = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    ChapterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoryid = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ChapterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterImageURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPublish = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    CAccess = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    tid = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_course");

            migrationBuilder.DropTable(
                name: "tbl_user");

            migrationBuilder.DropTable(
                name: "tblcourse_category");

            migrationBuilder.DropTable(
                name: "tblcourse_details");
        }
    }
}
