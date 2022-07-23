namespace IvyTech.IvyWebApi
{
	public class WebApplicationInfo : IWebApplicationInfo
	{
		private string _name;
		private string _version;
		private string _environment;
		private DateTime _startTime;

		public WebApplicationInfo(string name, string version, string environment)
		{
			_name = name;
			_version = version;
			_startTime = DateTime.UtcNow;
			_environment = environment;
		}

		public string Name => _name;
		public string Version => _version;
		public string Environment => _environment;
		public TimeSpan Uptime => DateTime.UtcNow - _startTime;
	}
}