using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services;

public class ApiService
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?country=tw&category={categoryName.ToLower()}&apikey=78b24dbd48e47cd8386dad6df0d08eac");
		return JsonConvert.DeserializeObject<Root>(response);
	}
}