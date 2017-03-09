namespace FantasyWatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedleaguemodelfixedplayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leagues");
        }
    }
}
