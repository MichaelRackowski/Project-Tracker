namespace PrescriptionCapstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Appointment = c.DateTime(),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Diagnosis = c.String(),
                        ScheduledAppointment = c.DateTime(),
                        ApplicationId = c.String(maxLength: 128),
                        Doctor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id)
                .Index(t => t.ApplicationId)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.Medications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MedicationConfirmed = c.Boolean(nullable: false),
                        ScheduledTimeToTake = c.DateTime(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Medications", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Patients", "ApplicationId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Doctors", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Medications", new[] { "Patient_Id" });
            DropIndex("dbo.Patients", new[] { "Doctor_Id" });
            DropIndex("dbo.Patients", new[] { "ApplicationId" });
            DropIndex("dbo.Doctors", new[] { "ApplicationId" });
            DropTable("dbo.Medications");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
