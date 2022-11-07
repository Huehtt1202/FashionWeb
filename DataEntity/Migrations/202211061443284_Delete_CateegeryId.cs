namespace DataEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_CateegeryId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "CategeryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "CategeryId", c => c.String());
        }
    }
}
