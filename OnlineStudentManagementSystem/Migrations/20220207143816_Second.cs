using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStudentManagementSystem.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_tblAddressCode_AddressCodeId",
                table: "tblStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_tblCourse_CourseId",
                table: "tblStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSubjectEnrollement_tblStudent_StudentId",
                table: "tblSubjectEnrollement");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSubjectEnrollement_tblSubject_SubjectId",
                table: "tblSubjectEnrollement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblSubjectEnrollement",
                table: "tblSubjectEnrollement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblSubject",
                table: "tblSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStudent",
                table: "tblStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblCourse",
                table: "tblCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblAdmin",
                table: "tblAdmin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblAddressCode",
                table: "tblAddressCode");

            migrationBuilder.DropColumn(
                name: "OutOfMarks",
                table: "tblSubject");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "tblStudent");

            migrationBuilder.RenameTable(
                name: "tblSubjectEnrollement",
                newName: "SubjectEnrollementnts");

            migrationBuilder.RenameTable(
                name: "tblSubject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "tblStudent",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "tblCourse",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "tblAdmin",
                newName: "Admins");

            migrationBuilder.RenameTable(
                name: "tblAddressCode",
                newName: "AddressCodes");

            migrationBuilder.RenameIndex(
                name: "IX_tblSubjectEnrollement_SubjectId",
                table: "SubjectEnrollementnts",
                newName: "IX_SubjectEnrollementnts_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_tblSubjectEnrollement_StudentId",
                table: "SubjectEnrollementnts",
                newName: "IX_SubjectEnrollementnts_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_tblStudent_CourseId",
                table: "Students",
                newName: "IX_Students_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_tblStudent_AddressCodeId",
                table: "Students",
                newName: "IX_Students_AddressCodeId");

            migrationBuilder.RenameColumn(
                name: "AdminUserName",
                table: "Admins",
                newName: "AdminUsername");

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Students",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdminUsername",
                table: "Admins",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectEnrollementnts",
                table: "SubjectEnrollementnts",
                column: "EnrollId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressCodes",
                table: "AddressCodes",
                column: "AddressCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AddressCodes_AddressCodeId",
                table: "Students",
                column: "AddressCodeId",
                principalTable: "AddressCodes",
                principalColumn: "AddressCodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectEnrollementnts_Students_StudentId",
                table: "SubjectEnrollementnts",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectEnrollementnts_Subjects_SubjectId",
                table: "SubjectEnrollementnts",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AddressCodes_AddressCodeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectEnrollementnts_Students_StudentId",
                table: "SubjectEnrollementnts");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectEnrollementnts_Subjects_SubjectId",
                table: "SubjectEnrollementnts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectEnrollementnts",
                table: "SubjectEnrollementnts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressCodes",
                table: "AddressCodes");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "tblSubject");

            migrationBuilder.RenameTable(
                name: "SubjectEnrollementnts",
                newName: "tblSubjectEnrollement");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "tblStudent");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "tblCourse");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "tblAdmin");

            migrationBuilder.RenameTable(
                name: "AddressCodes",
                newName: "tblAddressCode");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectEnrollementnts_SubjectId",
                table: "tblSubjectEnrollement",
                newName: "IX_tblSubjectEnrollement_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectEnrollementnts_StudentId",
                table: "tblSubjectEnrollement",
                newName: "IX_tblSubjectEnrollement_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CourseId",
                table: "tblStudent",
                newName: "IX_tblStudent_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_AddressCodeId",
                table: "tblStudent",
                newName: "IX_tblStudent_AddressCodeId");

            migrationBuilder.RenameColumn(
                name: "AdminUsername",
                table: "tblAdmin",
                newName: "AdminUserName");

            migrationBuilder.AddColumn<int>(
                name: "OutOfMarks",
                table: "tblSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "tblStudent",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "tblStudent",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdminUserName",
                table: "tblAdmin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblSubject",
                table: "tblSubject",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblSubjectEnrollement",
                table: "tblSubjectEnrollement",
                column: "EnrollId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStudent",
                table: "tblStudent",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblCourse",
                table: "tblCourse",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblAdmin",
                table: "tblAdmin",
                column: "AdminId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblAddressCode",
                table: "tblAddressCode",
                column: "AddressCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_tblAddressCode_AddressCodeId",
                table: "tblStudent",
                column: "AddressCodeId",
                principalTable: "tblAddressCode",
                principalColumn: "AddressCodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_tblCourse_CourseId",
                table: "tblStudent",
                column: "CourseId",
                principalTable: "tblCourse",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSubjectEnrollement_tblStudent_StudentId",
                table: "tblSubjectEnrollement",
                column: "StudentId",
                principalTable: "tblStudent",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSubjectEnrollement_tblSubject_SubjectId",
                table: "tblSubjectEnrollement",
                column: "SubjectId",
                principalTable: "tblSubject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
