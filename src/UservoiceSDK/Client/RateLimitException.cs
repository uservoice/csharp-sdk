using System;
namespace UserVoiceSdk.Client
{
	public class RateLimitException : ApiException
	{
		public RateLimitException() { }

		public RateLimitException(int errorCode, string message)
			: base(errorCode, message) { }

		public RateLimitException(int errorCode, string message, dynamic errorContent = null)
			: base(errorCode, message) 
		{
			this.ErrorContent = errorContent;
		}
	}
}
