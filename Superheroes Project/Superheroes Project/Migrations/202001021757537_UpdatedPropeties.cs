namespace Superheroes_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPropeties : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Heroes");
            AddColumn("dbo.Heroes", "SuperheroName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Heroes", "AlterEgo", c => c.String());
            AddColumn("dbo.Heroes", "PrimaryAbility", c => c.String());
            AddColumn("dbo.Heroes", "SecondaryAbility", c => c.String());
            AddColumn("dbo.Heroes", "CatchPhrase", c => c.String());
            AddPrimaryKey("dbo.Heroes", "SuperheroName");
            DropColumn("dbo.Heroes", "Id");
            DropColumn("dbo.Heroes", "firstName");
            DropColumn("dbo.Heroes", "lastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Heroes", "lastName", c => c.Int(nullable: false));
            AddColumn("dbo.Heroes", "firstName", c => c.Int(nullable: false));
            AddColumn("dbo.Heroes", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Heroes");
            DropColumn("dbo.Heroes", "CatchPhrase");
            DropColumn("dbo.Heroes", "SecondaryAbility");
            DropColumn("dbo.Heroes", "PrimaryAbility");
            DropColumn("dbo.Heroes", "AlterEgo");
            DropColumn("dbo.Heroes", "SuperheroName");
            AddPrimaryKey("dbo.Heroes", "Id");
        }
    }
}
