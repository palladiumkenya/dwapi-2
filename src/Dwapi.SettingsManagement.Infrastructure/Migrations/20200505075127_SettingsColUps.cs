﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwapi.SettingsManagement.Infrastructure.Migrations
{
    public partial class SettingsColUps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            if (migrationBuilder.ActiveProvider.ToLower().Contains("MySql".ToLower()))
            {
                migrationBuilder.Sql(@"SET FOREIGN_KEY_CHECKS = 0;");
                migrationBuilder.Sql(@"alter table Dockets convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(@"alter table EmrSystems convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(
                    @"alter table CentralRegistries convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(
                    @"alter table DatabaseProtocols convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(
                    @"alter table RestProtocols convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(@"alter table Extracts convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(@"alter table Resources convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(@"alter table AppMetrics convert to character set utf8 collate utf8_unicode_ci;");
                migrationBuilder.Sql(@"SET FOREIGN_KEY_CHECKS = 1;");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
