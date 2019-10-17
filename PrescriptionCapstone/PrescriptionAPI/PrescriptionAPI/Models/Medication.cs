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
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("SideEffect")]
        [Display(Name = "Side Effects")]
        public int? SideEffectID { get; set; }
        public SideEffect SideEffect { get; set; }
        public IEnumerable <SideEffect> SideEffects { get; set; }

        [ForeignKey("TimeOfDay")]
        [Display(Name="Time of Day")]
        public int?  TimeOfDayId { get; set; }
        public TimeOfDay TimeOfDay { get; set; }
        [ForeignKey("Treatment")]
        [Display(Name="Treatments")]
        public int?  TreatmentId { get; set; }
        public Treatment Treatment { get; set; }
        
    }
}