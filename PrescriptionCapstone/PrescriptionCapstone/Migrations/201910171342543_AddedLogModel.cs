namespace PrescriptionCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLogModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Text = c.String(),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Logs", new[] { "Patient_Id" });
            DropTable("dbo.Logs");
        }
    }
}
