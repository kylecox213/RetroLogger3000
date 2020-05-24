namespace RetroLogger3000.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GameConsole", "Type", c => c.String(maxLength: 25));
            AlterColumn("dbo.GameConsole", "Model", c => c.String(maxLength: 25));
            AlterColumn("dbo.Game", "Title", c => c.String(maxLength: 75));
            AlterColumn("dbo.GamePad", "Model", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GamePad", "Model", c => c.String());
            AlterColumn("dbo.Game", "Title", c => c.String());
            AlterColumn("dbo.GameConsole", "Model", c => c.String());
            AlterColumn("dbo.GameConsole", "Type", c => c.String());
        }
    }
}
