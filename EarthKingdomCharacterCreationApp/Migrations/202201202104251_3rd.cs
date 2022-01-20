namespace EarthKingdomCharacterCreationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CharacterClasses", new[] { "Team_TeamId" });
            DropTable("dbo.CharacterClasses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CharacterClasses",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        _FirstName = c.String(),
                        _LastName = c.String(),
                        _Alias = c.String(),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.CharacterId);
            
            CreateIndex("dbo.CharacterClasses", "Team_TeamId");
        }
    }
}
