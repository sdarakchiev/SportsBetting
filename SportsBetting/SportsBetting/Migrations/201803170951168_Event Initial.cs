namespace SportsBetting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        OddsForFirstTeam = c.Double(nullable: false),
                        OddsForDraw = c.Double(nullable: false),
                        OddsForSecondTeam = c.Double(nullable: false),
                        EventStartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
