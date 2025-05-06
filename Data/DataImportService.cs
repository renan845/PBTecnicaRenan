using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PBTecnicaRenan.Models;

namespace PBTecnicaRenan.Data
{
    public class DataImportService
    {
        private readonly DataContext _context;
        private readonly IHostEnvironment _env;

        public DataImportService(DataContext context, IHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task ImportFromJsonAsync()
        {
            var filePath = Path.Combine(_env.ContentRootPath, "Resources", "data.json");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("No se encontró el archivo JSON", filePath);

            var json = await File.ReadAllTextAsync(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<RootObject>(json, options);

            if (data != null)
            {
                _context.Users.AddRange(data.Users);
                _context.Roles.AddRange(data.Roles);
                _context.UserRoles.AddRange(data.UserRoles);
                _context.Procedures.AddRange(data.Procedures);
                _context.Fields.AddRange(data.Fields);
                _context.DataSets.AddRange(data.DataSets);

                await _context.SaveChangesAsync();
            }
        }
    }
}