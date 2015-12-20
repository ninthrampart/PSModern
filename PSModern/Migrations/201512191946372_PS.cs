namespace PSModern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Bargain_Guid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Work", "PS_ID", c => c.Int());
            CreateIndex("dbo.Work", "PS_ID");
            AddForeignKey("dbo.Work", "PS_ID", "dbo.PS", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Work", "PS_ID", "dbo.PS");
            DropIndex("dbo.Work", new[] { "PS_ID" });
            DropColumn("dbo.Work", "PS_ID");
            DropTable("dbo.PS");
        }
    }
}
