using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;

namespace RecipeManager.Services
{
	public class ApiAccess
	{
		private string endPoint = @"https://en.wikipedia.org/w/api.php?action=query&titles=Main%20Page&prop=revisions&rvprop=content&format=json";
				
		public string GetAPIRespone(string queryString)
		{
			try
			{
				string response;
				using (WebClient c = new WebClient())
				{
					response = c.DownloadString(endPoint + queryString);
				}
				JObject parsed = JObject.Parse(response);
				JObject json = (JObject)parsed["query"]["pages"];
				JToken token = json.First.First["extract"];
				return token.ToString();
			}
			catch (Exception)
			{
				throw;
			}
		}
	}	
}
