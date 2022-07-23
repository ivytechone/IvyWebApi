namespace IvyTech.IvyWebApi
{
	public interface IWebApplicationInfo
	{
		public string Name { get;  }
		public string Version { get; }
		public string Environment { get; }
		public TimeSpan Uptime { get; }
	}
}
