namespace Sitecore.Support
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;
    using Sitecore.XA.Foundation.IoC.ServiceCollection;
    using System;

    public class RegisterMvcControllers360691 : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            Type type = Type.GetType("Sitecore.Support.XA.Feature.Json.Controllers.JsonResultsController, Sitecore.Support.360691");
            serviceCollection.AddTransient(type);
            serviceCollection.AddTransient<Sitecore.Support.XA.Feature.Json.Repositories.IJsonResultsRepository, Sitecore.Support.XA.Feature.Json.Repositories.JsonResultsRepository>();
        }
    }
}