namespace IvyTech.IvyWebApi
{
	public class IvyWebApplicationInfo : IIvyWebApplicationInfo
	{
		private string _name;
		private string _version;
		private string _environment;
		private DateTime _startTime;

		public IvyWebApplicationInfo(string name, string version, string environment)
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