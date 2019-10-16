namespace PrescriptionCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Doctors", "UserId");
            AddForeignKey("dbo.Doctors", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Doctors", new[] { "UserId" });
            DropColumn("dbo.Doctors", "UserId");
        }
    }
}
