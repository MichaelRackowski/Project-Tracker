<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrescriptionAPI.Models
{
    public class SideEffect
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrescriptionAPI.Models
{
    public class SideEffect
    {
        //public SideEffect()
        //{
        //    this.Medications = new HashSet<Medication>();
        //}
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
       // public ICollection<Medication> Medications { get; set; }
    }
>>>>>>> 1b68758bfe5ffe065d994644d35453c4ad536de8
}