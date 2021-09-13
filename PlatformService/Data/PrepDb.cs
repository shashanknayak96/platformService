using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                
            }
        }

        private static void SeedData(AppDbContext _context)
        {
            if (!_context.Platforms.Any())
            {
                Console.WriteLine("Seeding data");
                _context.Platforms.AddRange(
                    new Platform() { Name = "DOTNET", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernet", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Docker", Publisher = "Microsoft", Cost = "Free" }
                );
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data.");
            }
        }
    }
}
