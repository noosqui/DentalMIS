//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DENTALMIS.Utility.HelperModel;

namespace DENTALMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrugDetail:SearchModel<DrugDetail>
    {
        public int DrugDetailId { get; set; }
        [Required]
        public string Indication { get; set; }
            [Required]
        public string Dosage { get; set; }
          [Required]
        public string Contraindication { get; set; }
          [Required]
        public string SideEffect { get; set; }
          [Required]
        public string UseInPregnency { get; set; }
          [Required]
        public string UseInLactation { get; set; }
          [Required]
        public string DrugInteraction { get; set; }
          [Required]
        public string Precaution { get; set; }
          [Required]
        public string Mechanism { get; set; }
        public bool IsActive { get; set; }
          [Required]
        public int GenericId { get; set; }
    
        public virtual DrugGeneric DrugGeneric { get; set; }
    }
}
