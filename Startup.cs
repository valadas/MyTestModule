// MIT License
// Copyright Eraware

using DotNetNuke.DependencyInjection;
using DotNetNuke.Instrumentation;
using Eraware.Modules.MyModule.Data;
using Eraware.Modules.MyModule.Data.Entities;
using Eraware.Modules.MyModule.Data.Repositories;
using Eraware.Modules.MyModule.Providers;
using Eraware.Modules.MyModule.Services.Items;
using Eraware.Modules.MyModule.Services.Localization;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Eraware.Modules.MyModule
{
    /// <summary>
    /// Implements the IDnnStartup interface to run at application start.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Startup : IDnnStartup
    {
        /// <summary>
        /// Registers the dependencies for injection.
        /// </summary>
        /// <param name="services">The services collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ModuleDbContext, ModuleDbContext>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemService, ItemService>();
            services.TryAddScoped(x => LoggerSource.Instance);
            services.AddScoped<ILocalizationService, LocalizationService>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IValidator<CreateItemDTO>, CreateItemDtoValidator>();
            services.AddScoped<IValidator<UpdateItemDTO>, UpdateItemDtoValidator>();
        }
    }
}