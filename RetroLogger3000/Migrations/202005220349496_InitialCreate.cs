namespace RetroLogger3000.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameConsole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Model = c.String(),
                        Functional = c.Boolean(nullable: false),
                        GamePadID = c.Int(nullable: false),
                        GameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Game", t => t.GameID, cascadeDelete: true)
                .ForeignKey("dbo.GamePad", t => t.GamePadID, cascadeDelete: true)
                .Index(t => t.GamePadID)
                .Index(t => t.GameID);
            
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        Clean = c.Boolean(nullable: false),
                        Complete = c.Boolean(nullable: false),
                        Beaten = c.Boolean(nullable: false),
                        Duplicate = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GamePad",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Type = c.String(),
                        Functional = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameConsole", "GamePadID", "dbo.GamePad");
            DropForeignKey("dbo.GameConsole", "GameID", "dbo.Game");
            DropIndex("dbo.GameConsole", new[] { "GameID" });
            DropIndex("dbo.GameConsole", new[] { "GamePadID" });
            DropTable("dbo.GamePad");
            DropTable("dbo.Game");
            DropTable("dbo.GameConsole");
        }
    }
}
