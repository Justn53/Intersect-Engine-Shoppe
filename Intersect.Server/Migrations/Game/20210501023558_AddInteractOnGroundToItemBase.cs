﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddInteractOnGroundToItemBase : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.AddColumn<bool>(
                name: "InteractOnGround",
                table: "Items",
                nullable: false,
                defaultValue: false );
        }

        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropColumn(
                name: "InteractOnGround",
                table: "Items" );
        }
    }
}
