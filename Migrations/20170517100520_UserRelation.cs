using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace forummvc.Migrations
{
    public partial class UserRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserData_Users_UserID",
                table: "UserData");

            migrationBuilder.AddForeignKey(
                name: "FK_UserData_User",
                table: "UserData",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserData_User",
                table: "UserData");

            migrationBuilder.AddForeignKey(
                name: "FK_UserData_Users_UserID",
                table: "UserData",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
