namespace IvyTech.IvyWebApi
{
	public static class WebApplicationExtensions
	{
		public static WebApplication AddPing(this WebApplication app)
		{
			app.MapGet("ping", (IIvyWebApplicationInfo info) => info);
			return app;
		}
	}
}
