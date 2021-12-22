using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace MySampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisCacheController : ControllerBase
    {
        public IDistributedCache DistributedCache { get; }

        public RedisCacheController(IDistributedCache distributedCache)
        {
            DistributedCache = distributedCache;
        }

        [HttpPost]
        public async Task InsertValue(string key, string value)
        {
            await DistributedCache.SetAsync(key, Encoding.UTF8.GetBytes(value));            
        }

        [HttpGet]
        public async Task<string> GetValue(string key)
        {
            var bytes = await DistributedCache.GetAsync(key);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
