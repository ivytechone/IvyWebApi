namespace IvyTech.IvyWebApi
{
	public static class WebApplicationBuilderExtensions
	{
		public static WebApplicationBuilder UseIvyWebApi(this WebApplicationBuilder builder, string name, string version)
		{
			var webApplicationInfoConfig = builder.Configuration.GetSection("WebApplicationInfo").Get<WebApplicationInfoConfig>();
			
			if (webApplicationInfoConfig is null || webApplicationInfoConfig.Environment is null)
			{
				throw new ArgumentNullException("WebApplicationInfo missing or invalid.");
			}

			builder.Services.AddSingleton<IWebApplicationInfo>(x => new WebApplicationInfo(name, version, webApplicationInfoConfig.Environment));
			return builder;
		}
	}
}
