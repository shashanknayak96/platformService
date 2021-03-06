using Microsoft.AspNetCore.Mvc;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        
        Platform GetPlatformById(int ID);

        void CreatePlatform(Platform platform);
    }
}
