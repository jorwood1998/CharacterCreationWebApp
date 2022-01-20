namespace EarthKingdomCharacterCreationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4th : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CharacterCreates", "SpecialItems", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CharacterCreates", "SpecialItems", c => c.String(nullable: false));
        }
    }
}
