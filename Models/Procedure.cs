using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Protocols.Configuration;

namespace PBTecnicaRenan.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId {get; set;}
        public string ProcedureName{get; set;}=string.Empty;
        public string Description {get;set;}=string.Empty;

        [ForeignKey("CreatedByUserID")]
        public virtual User CreatedByUser {get; set;}
        public int CreatedByUserID { get; set; }
        
        public DateTime CreatedDate{get;set;}=DateTime.Now;

         [ForeignKey("LastModifiedUserID")]
        public virtual User LastModifiedUser { get; set; }
        public int? LastModifiedUserID { get; set; }
        
        public DateTime? LastModifiedDate { get; set; } = DateTime.MinValue;
        public ICollection<DataSet> DataSet {get;set;}=new List<DataSet>();



    }
}