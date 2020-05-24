namespace RetroLogger3000.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TitleYearColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Game", name: "Title", newName: "Game Title");
            RenameColumn(table: "dbo.Game", name: "Year", newName: "Release Year");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Game", name: "Release Year", newName: "Year");
            RenameColumn(table: "dbo.Game", name: "Game Title", newName: "Title");
        }
    }
}
