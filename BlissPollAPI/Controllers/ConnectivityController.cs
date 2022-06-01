using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlissPollAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ConnectivityController : ControllerBase
	{
		[HttpGet("check")]
        public async Task<bool> Check()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://www.google.com");
                request.KeepAlive = false;
                request.Timeout = 1000;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
