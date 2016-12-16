using System;
using System.Collections.Generic;

namespace UservoiceSDK.Client
{
	/// <summary>
	/// Object to store rate limiting information
	/// </summary>
	public class RateLimiting
	{
		private const string LimitKey = "X-Rate-Limit-Limit";
		private const string RemainingKey = "X-Rate-Limit-Remaining";
		private const string ResetKey = "X-Rate-Limit-Reset";

		private DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		/// <summary>
		/// Number of requests client can make per rate limiting period
		/// </summary>
		/// <value>X-Rate-Limit-Limit</value>
		public string Limit { get; set;}

		/// <summary>
		/// Remaining requests client make in curent rate limiting period
		/// </summary>
		/// <value>X-Rate-Limit-Remaining</value>
		public string Remaining { get; set; }

		/// <summary>
		/// Unix time when current rate limiting period expires
		/// </summary>
		/// <value>X-Rate-Limit-Reset</value>
		public string Reset { get; set; }

		/// <summary>
		/// Default constructor
		/// </summary>
		public RateLimiting() 
		{
			Limit = string.Empty;
			Remaining = string.Empty;
			Reset = string.Empty;
		}

		/// <summary>
		/// Create a RateLimiting object that extracts and stores rate limiting information
		/// from response headers
		/// </summary>
		/// <param name="headers">Response headwers.</param>
		public RateLimiting(IDictionary<string, string> headers) 
		{
			Limit = headers.ContainsKey(LimitKey) ? headers[LimitKey] : string.Empty;
			Remaining = headers.ContainsKey(RemainingKey) ? headers[RemainingKey] : string.Empty;
			Reset = headers.ContainsKey(ResetKey) ? headers[ResetKey] : string.Empty;
		}

		/// <summary>
		/// Time the current rate limiting period will reset
		/// </summary>
		/// <returns>
		/// Date when current rate limiting period will reset.
		/// DateTime.MinValue if reset is invalid.
		/// </returns>
		public DateTime ResetAt() 
		{
			long l;
			if (long.TryParse(Reset, out l))
			{ 
				return Epoch.AddSeconds(l);
			}

			return DateTime.MinValue;
		}

		/// <summary>
		/// Gets time, in seconds, when the current rate limiting period will reset
		/// </summary>
		/// <returns>
		/// Seconds until the current rate limiting period expires.
		/// int.MinValue if reset is invalid.
		/// </returns>
		public int ResetIn() 
		{
			var resetAt = ResetAt();
			if (resetAt != DateTime.MinValue) 
			{
				return (resetAt - DateTime.Now).Seconds;	
			}
			return int.MinValue;
		}
	}
}
