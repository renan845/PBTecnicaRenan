using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PBTecnicaRenan.Data;
using PBTecnicaRenan.Dtos;
using PBTecnicaRenan.Interfaces;
using PBTecnicaRenan.Models;
using DataSet = System.Data.DataSet;
namespace PBTecnicaRenan.Services
{
    public class DataSetService:IDataSetService
    {
        private readonly DataContext _context;

        public DataSetService(DataContext context)
        {
            _context = context;
        }

        public Task<DataSetDto> CreateDataSetAsync(CreateDataSetDto createDataSetDto)
        {
            throw new NotImplementedException();
        }

        /*
     public async Task<DataSetDto> CreateDataSetAsync(CreateDataSetDto createDataSetDto)
       {
           var procedure = await _context.Procedures
               .FirstOrDefaultAsync(p => p.ProcedureId == createDataSetDto.ProcedureID);

           if (procedure == null)
           {
               return null;
           }

           var field = await _context.Fields
               .FirstOrDefaultAsync(f => f.FieldID == createDataSetDto.FieldID);

           if (field == null)
           {
               return null;
           }

           var newDataSet = new DataSet
           {
               DataSetName = createDataSetDto.DataSetName,
               Description = createDataSetDto.Description,
               Procedure = procedure,
               FieldId = createDataSetDto.FieldID
           };

           _context.DataSets.Add(newDataSet);
           await _context.SaveChangesAsync();

           return new DataSetDto
           {
               DataSetName = newDataSet.DataSetName,
               Description = newDataSet.
           };
       }*/

        public async Task<IEnumerable<DataSetDto>> GetDataSetsByUserIdAsync(int userId)
        {
            var dataSets = await _context.DataSets
                .Where(ds => ds.Procedure.CreatedByUserID == userId || ds.Procedure.LastModifiedUserID == userId)
                .Select(ds => new DataSetDto
                {
                    DataSetID = ds.DataSetID,
                    DataSetName = ds.DataSetName,
                    Description = ds.Description
                })
                .ToListAsync();

            return dataSets;
        }
    }

   
}