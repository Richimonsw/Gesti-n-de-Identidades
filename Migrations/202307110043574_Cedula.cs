﻿namespace RolesUsuario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cedula : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Cedula", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Cedula", c => c.Boolean(nullable: false));
        }
    }
}
