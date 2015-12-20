namespace PSModern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ResType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Work",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Executioner = c.String(),
                        InternalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExternalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PMP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkTypeID = c.Int(nullable: false),
                        ResTypeID = c.Int(nullable: false),
                        BNID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BN", t => t.BNID, cascadeDelete: true)
                .ForeignKey("dbo.ResType", t => t.ResTypeID, cascadeDelete: true)
                .ForeignKey("dbo.WorkType", t => t.WorkTypeID, cascadeDelete: true)
                .Index(t => t.WorkTypeID)
                .Index(t => t.ResTypeID)
                .Index(t => t.BNID);
            
            CreateTable(
                "dbo.WorkType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Work", "WorkTypeID", "dbo.WorkType");
            DropForeignKey("dbo.Work", "ResTypeID", "dbo.ResType");
            DropForeignKey("dbo.Work", "BNID", "dbo.BN");
            DropIndex("dbo.Work", new[] { "BNID" });
            DropIndex("dbo.Work", new[] { "ResTypeID" });
            DropIndex("dbo.Work", new[] { "WorkTypeID" });
            DropTable("dbo.WorkType");
            DropTable("dbo.Work");
            DropTable("dbo.ResType");
            DropTable("dbo.BN");
        }
    }
}
