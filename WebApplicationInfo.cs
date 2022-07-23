namespace IvyTech.IvyWebApi
{
	public class WebApplicationInfo : IWebApplicationInfo
	{
		private string _name;
		private string _version;
		private DateTime _startTime;

		public WebApplicationInfo(string name, string version)
		{
			_name = name;
			_version = version;
			_startTime = DateTime.UtcNow;
		}

		public string Name => _name;
		public string Version => _version;
		public TimeSpan Uptime => DateTime.UtcNow - _startTime;
	}
}