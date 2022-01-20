namespace EarthKingdomCharacterCreationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2nd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CharacterCreates", "TeamId", "dbo.Teams");
            DropIndex("dbo.CharacterCreates", new[] { "TeamId" });
            RenameColumn(table: "dbo.CharacterCreates", name: "TeamId", newName: "Team_TeamId");
            AlterColumn("dbo.CharacterCreates", "Team_TeamId", c => c.Int());
            CreateIndex("dbo.CharacterCreates", "Team_TeamId");
            AddForeignKey("dbo.CharacterCreates", "Team_TeamId", "dbo.Teams", "TeamId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CharacterCreates", "Team_TeamId", "dbo.Teams");
            DropIndex("dbo.CharacterCreates", new[] { "Team_TeamId" });
            AlterColumn("dbo.CharacterCreates", "Team_TeamId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.CharacterCreates", name: "Team_TeamId", newName: "TeamId");
            CreateIndex("dbo.CharacterCreates", "TeamId");
            AddForeignKey("dbo.CharacterCreates", "TeamId", "dbo.Teams", "TeamId", cascadeDelete: true);
        }
    }
}
