using System.Text.Json;

namespace JobForumAPI.DAL
{
    public class JobAdData
    {
        public static async Task<Models.JobAd> GetJobAdsAsync()
        {
            Models.JobAd job = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://links.api.jobtechdev.se");
                HttpResponseMessage response = await client.GetAsync("/joblinks?offset=10&limit=10");

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    job = JsonSerializer.Deserialize<Models.JobAd>(responseString);
                }
            }

            return job;
        }

        public static async Task<Models.Hit> GetHitAsync()
        {
            Models.Hit job = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://links.api.jobtechdev.se");
                HttpResponseMessage response = await client.GetAsync("/joblinks?offset=10&limit=10");

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    job = JsonSerializer.Deserialize<Models.Hit>(responseString);
                }
            }

            return job;
        }
    }
}
