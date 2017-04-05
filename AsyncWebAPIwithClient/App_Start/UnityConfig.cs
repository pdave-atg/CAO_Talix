using AsyncWebAPIwithClient.Models;
using AsyncWebAPIwithClient.Repository;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace AsyncWebAPIwithClient
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPersonRepository<PersonInfo, int>, PersonRepository>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}