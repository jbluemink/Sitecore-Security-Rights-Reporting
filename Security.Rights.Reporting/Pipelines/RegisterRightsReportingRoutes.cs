namespace Security.Rights.Reporting.Pipelines
{ 
    using System.Web.Mvc;
    using System.Web.Routing;
    using Sitecore.Pipelines;

    public class RegisterWebApiRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("Security.Rights.Reporting.Controllers", "api/rightsreporting/{action}/{page}", new
            {
                controller = "RightsReporting"
            });
        }
    }
}