using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrescriptionAPI.Models
{
    public class Medication
    {
        //public Medication()
        //{
        //    this.SideEffects = new HashSet<SideEffect>();
        //    this.TimeOfDays = new HashSet<TimeOfDay>();
        //    this.Treatments = new HashSet<Treatment>();


        //}
       
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //[ForeignKey("SideEffect")]
        //[Display(Name = "Side Effects")]
        //public int? SideEffectID { get; set; }
        //public SideEffect SideEffect { get; set; }
        ////public ICollection<SideEffect> SideEffects { get; set; }

        //[ForeignKey("TimeOfDay")]
        //[Display(Name = "Time of Day")]
        //public int? TimeOfDayId { get; set; }
        //public TimeOfDay TimeOfDay { get; set; }
        ////public ICollection<TimeOfDay> TimeOfDays {get;set;}

        //[ForeignKey("Treatment")]
        //[Display(Name="Treatments")]
        //public int?  TreatmentId { get; set; }
        //public Treatment Treatment { get; set; }
        ////public ICollection<Treatment> Treatments { get; set; }
        
    }
}