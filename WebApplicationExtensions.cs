namespace IvyTech.IvyWebApi
{
	public static class WebApplicationExtensions
	{
		public static WebApplication AddPing(this WebApplication app)
		{
			app.MapGet("ping", (IWebApplicationInfo info) => info);
			return app;
		}
	}
}
