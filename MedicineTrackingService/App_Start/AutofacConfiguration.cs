using Autofac;
using Autofac.Integration.WebApi;
using MedicineTrackingRepository;
using System.Reflection;
using System.Web.Http;

namespace MedicineTrackingService.App_Start
{
    /// <summary>
    /// Autofac Configuration for DI
    /// </summary>
    public class AutofacConfiguration
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            IContainer container = RegisterServices(new ContainerBuilder());
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            containerBuilder.RegisterType<MedicineCommandRepository>().As<IMedicineCommandRepository>();
            containerBuilder.RegisterType<MedicineQueryRepository>().As<IMedicineQueryRepository>();

            Container = containerBuilder.Build();

            return Container;
        }

    }
}