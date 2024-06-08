using Microsoft.AspNetCore.Mvc;

namespace JobForumAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobAdController : ControllerBase
    {
        [HttpGet]
       public async Task<Models.JobAd> GetAdsAsync()
        {
            return await DAL.JobAdManager.GetAllJobAds();
        }

        [HttpGet("{municipality}")]
        public async Task<List<Models.Hit>> GetJobAds(string municipality)
        {
            return await DAL.JobAdManager.GetCertainJobAd(municipality);
        }
    }
}
