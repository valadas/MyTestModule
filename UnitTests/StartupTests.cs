using DotNetNuke.Instrumentation;
using Eraware.Modules.MyModule.Data;
using Eraware.Modules.MyModule.Data.Repositories;
using Eraware.Modules.MyModule.Providers;
using Eraware.Modules.MyModule.Services.Items;
using Eraware.Modules.MyModule.Services.Localization;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Xunit;

namespace UnitTests
{
    public class StartupTests
    {
        [Fact]
        public void Startup_RegistersAllRequiredServices()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();
            var startup = new Eraware.Modules.MyModule.Startup();
            var types = new List<Type>()
            {
                typeof(ModuleDbContext),
                typeof(IItemRepository),
                typeof(IItemService),
                typeof(ILoggerSource),
                typeof(ILocalizationService),
                typeof(IDateTimeProvider),
                typeof(IValidator<CreateItemDTO>),
                typeof(IValidator<UpdateItemDTO>),
            };

            // Act
            startup.ConfigureServices(services);

            // Assert
            types.ForEach(type =>
            {
                Assert.Contains(services, s => s.ServiceType == type);
            });

            Assert.Equal(types.Count, services.Count);
        }
    }
}