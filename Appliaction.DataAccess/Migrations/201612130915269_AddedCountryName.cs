namespace Appliaction.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCountryName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Country", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Country", "Name", c => c.Int(nullable: false));
        }
    }
}
