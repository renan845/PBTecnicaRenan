using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PBTecnicaRenan.Dtos;
using PBTecnicaRenan.Interfaces;

namespace PBTecnicaRenan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class DataSetsController : ControllerBase
    {
       private readonly IDataSetService _dataSetService;

        public DataSetsController(IDataSetService dataSetService)
        {
            _dataSetService = dataSetService;
        }
        

        [HttpGet("by-user/{userId}")]
        public async Task<IActionResult> GetDataSetsByUser(int userId)
        {
            var result = await _dataSetService.GetDataSetsByUserIdAsync(userId);
            return Ok(result);
        }
         [HttpPost]
        public async Task<IActionResult> CreateDataSet([FromBody] CreateDataSetDto createDataSetDto)
        {
            // Validar que el ProcedureID y el FieldID existan en la base de datos
            var result = await _dataSetService.CreateDataSetAsync(createDataSetDto);

            if (result == null)
            {
                return BadRequest("ProcedureID or FieldID is invalid.");
            }

            return CreatedAtAction(nameof(GetDataSetsByUser), new { userId = createDataSetDto }, result);
        }
        
    }
}