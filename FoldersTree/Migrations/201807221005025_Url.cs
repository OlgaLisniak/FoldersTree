namespace FoldersTree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Url : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FolderModels", "Url", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FolderModels", "Url", c => c.String(nullable: false));
        }
    }
}
