using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PBTecnicaRenan.Models
{
    public class UserRol
    {
        [Key]
        public int ID{get;set;}
        public virtual User Users {get;set;}
        public int UserID {get;set;}
        public virtual Role Roles {get;set;}
        public int RolesID {get;set;}
    }
}