namespace EarthKingdomCharacterCreationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appearances",
                c => new
                    {
                        AppearanceId = c.Int(nullable: false, identity: true),
                        CharacterHeight = c.Int(nullable: false),
                        CharacterBuild = c.Int(nullable: false),
                        CharacterHairStyle = c.Int(nullable: false),
                        CharacterHairColor = c.Int(nullable: false),
                        CharacterEyeColor = c.Int(nullable: false),
                        CharacterSkinColor = c.Int(nullable: false),
                        SpecialCharacteristics = c.String(),
                    })
                .PrimaryKey(t => t.AppearanceId);
            
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        AttributeId = c.Int(nullable: false, identity: true),
                        _strength = c.Int(nullable: false),
                        _dexterity = c.Int(nullable: false),
                        _constitution = c.Int(nullable: false),
                        _intelligence = c.Int(nullable: false),
                        _wisdom = c.Int(nullable: false),
                        _charisma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttributeId);
            
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
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.CharacterCreates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        Strength = c.String(nullable: false),
                        Dexterity = c.String(nullable: false),
                        Constitution = c.String(nullable: false),
                        Intelligence = c.String(nullable: false),
                        Wisdom = c.String(nullable: false),
                        Charisma = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Alias = c.String(),
                        Height = c.Int(nullable: false),
                        Build = c.String(nullable: false),
                        HairStyle = c.String(nullable: false),
                        HairColor = c.String(nullable: false),
                        EyeColor = c.String(nullable: false),
                        SkinColor = c.String(nullable: false),
                        SpecialItems = c.String(nullable: false),
                        Attributes_AttributeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Attributes", t => t.Attributes_AttributeId)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.Attributes_AttributeId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CharacterCreates", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.CharacterClasses", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.CharacterCreates", "Attributes_AttributeId", "dbo.Attributes");
            DropIndex("dbo.CharacterCreates", new[] { "Attributes_AttributeId" });
            DropIndex("dbo.CharacterCreates", new[] { "TeamId" });
            DropIndex("dbo.CharacterClasses", new[] { "Team_TeamId" });
            DropTable("dbo.Teams");
            DropTable("dbo.CharacterCreates");
            DropTable("dbo.CharacterClasses");
            DropTable("dbo.Attributes");
            DropTable("dbo.Appearances");
        }
    }
}
