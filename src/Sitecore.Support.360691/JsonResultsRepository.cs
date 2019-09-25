namespace Sitecore.Support.XA.Feature.Json.Repositories
{
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.XA.Feature.Json.Models;
    using Sitecore.XA.Feature.Json.Repositories;
    using Sitecore.XA.Foundation.IoC;
    using Sitecore.XA.Foundation.JsonVariants.Repositories;
    using Sitecore.XA.Foundation.Mvc.Repositories.Base;
    using Sitecore.XA.Foundation.Search.Models;
    using Sitecore.XA.Foundation.Search.Services;
    using Sitecore.XA.Foundation.SitecoreExtensions.Extensions;
    using System.Globalization;
    using System.Linq;
    using System.Web;

    public class JsonResultsRepository : Sitecore.XA.Feature.Json.Repositories.JsonResultsRepository, IJsonResultsRepository
    {

        public JsonResultsRepository(ISearchService searchService, IScopeService scopeService) : base(searchService, scopeService)
        {

        }

        protected virtual string ItemId
        {
            get
            {
                if (base.Context?.Item == null)
                {
                    return null;
                }
                return base.Context.Item.ID.ToString();
            }
        }
        protected virtual string Site
        {
            get
            {
                if (base.Context?.Site == null)
                {
                    return null;
                }
                return base.Context.Site.Name;
            }
        }

        public override IRenderingModelBase GetModel()
        {
            JsonResultsModel jsonResultsModel = new JsonResultsModel();
            FillBaseProperties(jsonResultsModel);
            jsonResultsModel.Items = SearchService.Search(HttpContext.Current.Request.Params["q"], ScopeService.GetScopes(PageContext.Current, Rendering.Parameters["Scope"]), Language, DefaultSortOrder, PageSize, Offset, itemid:ItemId, site:Site ).ToList();
            jsonResultsModel.PropertyName = PropertyName;
            return jsonResultsModel;
        }
    }
}