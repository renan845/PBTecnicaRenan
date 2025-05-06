using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PBTecnicaRenan.Models
{
    public class Field
    {
        [Key]
        public int FieldID{get; set;}
        public string FieldName{get; set;}=string.Empty;
        public string DataType{get;set;}=string.Empty;
        public ICollection<DataSet> DataSet {get;set;}=new List<DataSet>();

    }
}