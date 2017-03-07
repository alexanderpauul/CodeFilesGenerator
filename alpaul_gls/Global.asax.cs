using System;
using System.Web.Routing;

namespace alpaul_gls
{
    public class Global : System.Web.HttpApplication
	{

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected void RegisterRoutes(RouteCollection routes)
        {
            // Generator
            routes.MapPageRoute("Generator-Connection", "Generator/Connection", "~/SGI/generator/generator_connection.aspx");
            routes.MapPageRoute("Generator-Process", "Generator/Process", "~/SGI/generator/generator_process.aspx");
            routes.MapPageRoute("Generator-Tables", "Generator/Tables", "~/SGI/generator/generator_tables.aspx");
            routes.MapPageRoute("Generator-Download", "Generator/Download", "~/SGI/generator/generator_download.aspx");
        }

        protected void Session_Start(object sender, EventArgs e) 
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e) 
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e) 
		{

		}

		protected void Application_Error(object sender, EventArgs e) 
		{

		}

		protected void Session_End(object sender, EventArgs e) 
		{

		}

		protected void Application_End(object sender, EventArgs e) 
		{

		}
	}
}