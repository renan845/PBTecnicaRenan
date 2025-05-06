using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace PBTecnicaRenan.Models
{
    public class DataSet
    {
        [Key]
        public int DataSetID {get; set;}
        public string DataSetName {get;set;}=string.Empty;
        public string Description {get;set;}=string.Empty;
        public virtual Procedure Procedure{get;set;}
        public int ProcedureID {get; set;}
        public virtual Field Fields {get; set;}
        public int FieldId {get; set;}
        public DateTime CreatedDate{get; set;}=DateTime.Now;
        public DateTime? LastModifiedDate{ get; set;}=DateTime.MinValue;

        
    }
}