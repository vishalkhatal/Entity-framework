namespace setDefaultValue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fares", "NewRate", 
                c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fares", "NewRate");
        }
    }
}
