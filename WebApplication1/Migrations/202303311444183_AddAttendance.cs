﻿namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Attendances", newName: "Attendances");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Attendances", newName: "Attendances");
        }
    }
}
