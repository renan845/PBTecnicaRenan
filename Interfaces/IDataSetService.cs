using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PBTecnicaRenan.Dtos;
using PBTecnicaRenan.Services;
using DataSetDto = PBTecnicaRenan.Dtos.DataSetDto;

namespace PBTecnicaRenan.Interfaces
{
    public interface IDataSetService
    {
  
        Task<IEnumerable<DataSetDto>> GetDataSetsByUserIdAsync(int userId); 
        Task<DataSetDto> CreateDataSetAsync(CreateDataSetDto createDataSetDto);

    }
}