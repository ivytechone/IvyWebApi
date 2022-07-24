namespace IvyTech.IvyWebApi
{
	public static class WebApplicationBuilderExtensions
	{
		public static WebApplicationBuilder UseIvyWebApi(this WebApplicationBuilder builder, string name, string version)
		{
			IvyWebApplication.Configuration = builder.Configuration;

			var webApplicationInfoConfig = IvyWebApplication.Configuration.GetSection("WebApplicationInfo").Get<IvyWebApplicationInfoConfig>();
			
			if (webApplicationInfoConfig is null || webApplicationInfoConfig.Environment is null)
			{
				throw new ArgumentNullException("WebApplicationInfo missing or invalid.");
			}

			IvyWebApplication.Info = new IvyWebApplicationInfo(name, version, webApplicationInfoConfig.Environment);

			builder.Services.AddSingleton<IIvyWebApplicationInfo>(x => IvyWebApplication.Info);
			return builder;
		}
	}
}
