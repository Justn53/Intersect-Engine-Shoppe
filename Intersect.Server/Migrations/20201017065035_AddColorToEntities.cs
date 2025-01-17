﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddColorToEntities : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Players",
                nullable: false,
                defaultValue: "{\"A\":255,\"R\":255,\"G\":255,\"B\":255}" );
        }

        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Players" );
        }
    }
}
