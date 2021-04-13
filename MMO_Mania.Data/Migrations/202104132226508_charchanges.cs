namespace MMO_Mania.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class charchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Game", c => c.String(nullable: false));
            AlterColumn("dbo.Character", "Char_Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Character", "Char_Name", c => c.String(nullable: false));
            DropColumn("dbo.Character", "Game");
        }
    }
}
