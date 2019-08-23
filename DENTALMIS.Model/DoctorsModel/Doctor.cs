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
    
    public partial class Doctor:SearchModel<Doctor>
    {
        public int DoctorId { get; set; }
        [Required]
        [DisplayName("Doctor Name")]
        public string Name { get; set; }
        [Required]
        public string RegistrationNo { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]

        public string Website { get; set; }
        [Required]
        public string FacebookId { get; set; }
        [Required]
        public string Twitter { get; set; }
   
        public bool IsActive { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public int DessignationId { get; set; }
    
        public virtual DoctorsDesignation DoctorsDesignation { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
