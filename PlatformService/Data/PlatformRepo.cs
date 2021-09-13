using Microsoft.AspNetCore.Mvc;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }
            else{
                _context.Platforms.Add(platform);
            }
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int ID)
        {
            return _context.Platforms.FirstOrDefault(x => x.Id == ID);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
            
        }
    }
}
