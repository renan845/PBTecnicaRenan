using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBTecnicaRenan.Dtos
{
    public class CreateDataSetDto
    {
        public string DataSetName { get; set; }
        public string Description { get; set; }
        public int ProcedureID { get; set; }
        public int FieldID { get; set; }



    }
}