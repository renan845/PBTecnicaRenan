using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBTecnicaRenan.Models
{
    public class RootObject
    {
         public List<User> Users { get; set; }
        public List<Role> Roles { get; set; }
        public List<UserRol> UserRoles { get; set; }
        public List<Procedure> Procedures { get; set; }
        public List<Field> Fields { get; set; }
        public List<DataSet> DataSets { get; set; }
    }
}