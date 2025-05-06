using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PBTecnicaRenan.Models
{
    public class Role
    {
        [Key]
        public int RolesID {get;set;}
        public  string RoleName {get;set;}=string.Empty;
        public string Descripction{get;set;}=string.Empty; 
        public ICollection<UserRol> UserRol {get;set;} =new List<UserRol>();

    }
}