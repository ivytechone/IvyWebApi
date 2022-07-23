namespace IvyTech.IvyWebApi
{
	public static class WebApplicationBuilderExtensions
	{
		public static WebApplicationBuilder UseIvyWebApi(this WebApplicationBuilder builder, string name, string version)
		{			
			builder.Services.AddSingleton<IWebApplicationInfo>(x => new WebApplicationInfo(name, version));
			return builder;
		}
	}
}
