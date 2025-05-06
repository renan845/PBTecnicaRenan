using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PBTecnicaRenan.Models
{
    public class User
    {
        [Key]
        public int UserID {get;set;}
        [Required]
        [StringLength(50)]
        public String Username{get;set;}=String.Empty;
        [Required]
        public String Password{get;set;}=string.Empty;
        [Required]
        [EmailAddress]
        public String Email{get;set;}=string.Empty;
        public ICollection<UserRol> UserRol {get;set;}=new List<UserRol>();
        public virtual ICollection<Procedure> CreatedProcedures { get; set; }
        public virtual ICollection<Procedure> ModifiedProcedures { get; set; }
        

    }
}