﻿namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoCategoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "categoria");
        }
    }
}
