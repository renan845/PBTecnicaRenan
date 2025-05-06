using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace PBTecnicaRenan.Dtos
{
    public class DataSetDto
    {
        public int DataSetID{get; set;}
        public string DataSetName {get;set;}=string.Empty;
        public string Description {get;set;}=string.Empty;
       

        
    }
}