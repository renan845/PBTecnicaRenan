using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PBTecnicaRenan.Data;

namespace PBTecnicaRenan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImportController : ControllerBase
    {
        private readonly DataImportService _importService;

        public ImportController(DataImportService importService)
        {
            _importService = importService;
        }

        [HttpPost("json")]
        public async Task<IActionResult> ImportJsonData()
        {
            await _importService.ImportFromJsonAsync();
            return Ok("Datos importados correctamente desde data.json");
        }
    }
}