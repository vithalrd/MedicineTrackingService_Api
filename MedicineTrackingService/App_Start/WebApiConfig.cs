using MedicineTrackingRepository;
using MedicineTrackingService.App_Start;
using System.Web.Http;

namespace MedicineTrackingService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            AutofacConfiguration.Initialize(config);

            // this is to get data in static list to support demo application
            PrepareMedicineData.MedicineList = PrepareMedicineData.GetMedicines();
        }
    }
}
