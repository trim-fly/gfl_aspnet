using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace forummvc.Migrations
{
    public partial class NullableThread : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thread_Category",
                table: "Threads");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Threads",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Thread_Category",
                table: "Threads",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thread_Category",
                table: "Threads");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Threads",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Thread_Category",
                table: "Threads",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
