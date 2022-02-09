using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStudentManagementSystem.Migrations
{
    public partial class StudentCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAddressCode",
                columns: table => new
                {
                    AddressCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAddressCode", x => x.AddressCodeId);
                });

            migrationBuilder.CreateTable(
                name: "tblAdmin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdmin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "tblCourse",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCourse", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "tblSubject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "varchar", nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: false),
                    OutOfMarks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "tblStudent",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    AddressCodeId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudent", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_tblStudent_tblAddressCode_AddressCodeId",
                        column: x => x.AddressCodeId,
                        principalTable: "tblAddressCode",
                        principalColumn: "AddressCodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblStudent_tblCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "tblCourse",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSubjectEnrollement",
                columns: table => new
                {
                    EnrollId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubjectEnrollement", x => x.EnrollId);
                    table.ForeignKey(
                        name: "FK_tblSubjectEnrollement_tblStudent_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tblStudent",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblSubjectEnrollement_tblSubject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "tblSubject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_AddressCodeId",
                table: "tblStudent",
                column: "AddressCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStudent_CourseId",
                table: "tblStudent",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSubjectEnrollement_StudentId",
                table: "tblSubjectEnrollement",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSubjectEnrollement_SubjectId",
                table: "tblSubjectEnrollement",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAdmin");

            migrationBuilder.DropTable(
                name: "tblSubjectEnrollement");

            migrationBuilder.DropTable(
                name: "tblStudent");

            migrationBuilder.DropTable(
                name: "tblSubject");

            migrationBuilder.DropTable(
                name: "tblAddressCode");

            migrationBuilder.DropTable(
                name: "tblCourse");
        }
    }
}
