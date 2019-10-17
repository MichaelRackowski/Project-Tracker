namespace PrescriptionCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userRolesAdded : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Doctors", name: "ApplicationId", newName: "UserId");
            RenameColumn(table: "dbo.Patients", name: "ApplicationId", newName: "UserId");
            RenameIndex(table: "dbo.Doctors", name: "IX_ApplicationId", newName: "IX_UserId");
            RenameIndex(table: "dbo.Patients", name: "IX_ApplicationId", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Patients", name: "IX_UserId", newName: "IX_ApplicationId");
            RenameIndex(table: "dbo.Doctors", name: "IX_UserId", newName: "IX_ApplicationId");
            RenameColumn(table: "dbo.Patients", name: "UserId", newName: "ApplicationId");
            RenameColumn(table: "dbo.Doctors", name: "UserId", newName: "ApplicationId");
        }
    }
}
