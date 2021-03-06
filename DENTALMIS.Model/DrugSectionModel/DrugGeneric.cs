//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DENTALMIS.Utility.HelperModel;

namespace DENTALMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrugGeneric : SearchModel<DrugGeneric>
    {
        public DrugGeneric()
        {
            this.DrugBrands = new HashSet<DrugBrand>();
            this.DrugDetails = new HashSet<DrugDetail>();
        }
    
        public int GenericId { get; set; }
        [Required]
        [DisplayName("Generic Name")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<DrugBrand> DrugBrands { get; set; }
        public virtual ICollection<DrugDetail> DrugDetails { get; set; }
    }
}
