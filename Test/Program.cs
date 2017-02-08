using System;
using System.Collections.Generic;
using UservoiceSDK.Client;

namespace Test
{
	class MainClass
	{
		private static string ApiKey = "OkT1NdPLTXLQzPPSxLUDg";
		private static string ApiSecret = "flixlIrBToZg7ZvnrPIMzg591sputKcvmUDxNTYY";
		private static string Subdomain = "uservoice";
		private static string Domain = "uservoice.com";

		// Credentials for authenticating as a user
		private static string Username = "jordan.curd@uservoice.com";
		private static string Password = "Somepassword1234!";

		public static void Main(string[] args)
		{
			var client = new ApiClient(subdomain: Subdomain,
									   clientId: ApiKey,
									   domain: Domain,
									   clientSecret: ApiSecret);

			// Authentication takes place on request when a token is not available
			// However, client can explicitly login using the functions below
			//client.Login(ApiKey, ApiSecret);
			//client.LoginAsUser(ApiKey, Username, Password);

			try
			{
				var response = client.Suggestions.Get(page: 1, perPage: 10, includes: new List<string>() { "categories", "labels" });
				foreach (var sug in response.Suggestions)
				{
					Console.WriteLine(sug.Title);
				}
			}
			catch (RateLimitException)
			{
				Console.WriteLine(string.Format("Rate limited! Limit: {0}, Remaining: {1}, Reset: {2}"),
				                  client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
				Console.WriteLine(string.Format("Will reset at {0}, which is in {1} seconds"),
				                  client.RateLimiting.ResetAt(), client.RateLimiting.ResetIn());
			}
			catch (ApiException e)
			{
				Console.WriteLine(string.Format("Error: {0}", e));
			}
		}
	}
}
