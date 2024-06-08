using System.Linq;

namespace JobForumAPI.DAL
{
    public class JobAdManager
    {
        public static Models.JobAd JobAds { get; set; }

        public static Models.Hit[] hits { get; set; }

        public static async Task<Models.JobAd> GetAllJobAds()
        {
            if (JobAds == null)
            {
                JobAds = await JobAdData.GetJobAdsAsync();
            }
            return JobAds;
        }

        public static async Task<List<Models.Hit>> GetCertainJobAd(string municipality)
        {
            if (hits == null)
            {
                JobAds = await JobAdData.GetJobAdsAsync();
            }

            var existingJobAd = JobAds.hits.Where(p => p.workplace_addresses.Length > 0 && p.workplace_addresses[0].municipality == municipality).ToList();
                //Hits.workplace_addresses.Where(m => m.municipality ==  municipality).ToList();
                //.hits.Where(p =>p.workplace_addresses.Length >0 && p.workplace_addresses[0].municipality == municipality).ToList();

            return existingJobAd;

        }
    }
}
