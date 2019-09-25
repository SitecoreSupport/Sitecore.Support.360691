namespace Sitecore.Support.XA.Feature.Json.Controllers
{
    using Sitecore.XA.Foundation.Mvc.Controllers;
    using Sitecore.Support.XA.Feature.Json.Repositories;

    public class JsonResultsController : StandardController
    {
        protected IJsonResultsRepository JsonResultsRepository;

        public JsonResultsController(IJsonResultsRepository jsonResultsRepository)
        {
            JsonResultsRepository = jsonResultsRepository;
        }

        protected override object GetModel()
        {
            return JsonResultsRepository.GetModel();
        }
    }
}