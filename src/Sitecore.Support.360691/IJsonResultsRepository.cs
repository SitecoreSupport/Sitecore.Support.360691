namespace Sitecore.Support.XA.Feature.Json.Repositories
{
    using Sitecore.XA.Foundation.IoC;
    using Sitecore.XA.Foundation.Mvc.Repositories.Base;

    public interface IJsonResultsRepository : IModelRepository, IControllerRepository, IAbstractRepository<IRenderingModelBase>
    {
    }
}