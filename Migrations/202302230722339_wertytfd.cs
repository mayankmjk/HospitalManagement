namespace HospitalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wertytfd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "User_type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "User_type");
        }
    }
}
