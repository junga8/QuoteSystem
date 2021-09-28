using Service;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace TaskManagementSystem
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();
			
			// register all your components with the container here
			// it is NOT necessary to register your controllers
			
			 container.RegisterType<IQuoteService, QuoteService>();
			
			
			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}
	}
}