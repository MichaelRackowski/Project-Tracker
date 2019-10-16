namespace PrescriptionAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicationUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medications", "SideEffectID", "dbo.SideEffects");
            DropForeignKey("dbo.Medications", "TimeOfDayId", "dbo.TimeOfDays");
            DropForeignKey("dbo.Medications", "TreatmentId", "dbo.Treatments");
            DropIndex("dbo.Medications", new[] { "SideEffectID" });
            DropIndex("dbo.Medications", new[] { "TimeOfDayId" });
            DropIndex("dbo.Medications", new[] { "TreatmentId" });
            AddColumn("dbo.Medications", "SideEffect", c => c.String());
            AddColumn("dbo.Medications", "TimeOfDay", c => c.String());
            AddColumn("dbo.Medications", "Treatment", c => c.String());
            DropColumn("dbo.Medications", "SideEffectID");
            DropColumn("dbo.Medications", "TimeOfDayId");
            DropColumn("dbo.Medications", "TreatmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medications", "TreatmentId", c => c.Int());
            AddColumn("dbo.Medications", "TimeOfDayId", c => c.Int());
            AddColumn("dbo.Medications", "SideEffectID", c => c.Int());
            DropColumn("dbo.Medications", "Treatment");
            DropColumn("dbo.Medications", "TimeOfDay");
            DropColumn("dbo.Medications", "SideEffect");
            CreateIndex("dbo.Medications", "TreatmentId");
            CreateIndex("dbo.Medications", "TimeOfDayId");
            CreateIndex("dbo.Medications", "SideEffectID");
            AddForeignKey("dbo.Medications", "TreatmentId", "dbo.Treatments", "Id");
            AddForeignKey("dbo.Medications", "TimeOfDayId", "dbo.TimeOfDays", "Id");
            AddForeignKey("dbo.Medications", "SideEffectID", "dbo.SideEffects", "Id");
        }
    }
}
