// <summary>
// <copyright file="DependencyInjector.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.DependencyInjection
{
    using AutoMapper;
    using Axity.DataAccessEntity.Entities.Context;
    using Axity.DataAccessEntity.Services.Mapping;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Class for DependencyInjector.
    /// </summary>
    public static class DependencyInjector
    {
        private static IServiceCollection Services { get; set; }

        /// <summary>
        /// Method to register Services.
        /// </summary>
        /// <param name="services">Service Collection.</param>
        /// <returns>Interface Service Collection.</returns>
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;
            Services.AddTransient<IDatabaseContext, DatabaseContext>();
            return Services;
        }

        /// <summary>
        /// Method to add Db Context.
        /// </summary>
        /// <param name="configuration">Configuration Options.</param>
        public static void AddDbContext(IConfiguration configuration)
        {
             Services.AddDbContextPool<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString(nameof(DatabaseContext))));

            // Services.AddDbContextPool<DatabaseContext>(opt =>
            // {
            //    opt.UseMySql(configuration.GetConnectionString(nameof(DatabaseContext)), MySqlServerVersion.AutoDetect(configuration.GetConnectionString(nameof(DatabaseContext))));
            // });

            // Services.AddDbContextPool<DatabaseContext>(options => options.UseSqlite(configuration.GetConnectionString("DatabaseContext")));
        }

        /// <summary>
        /// Add configuration Auto Mapper.
        /// </summary>
        public static void AddAutoMapper()
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapperProfile()); });
            Services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}
