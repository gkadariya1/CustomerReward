using CustomerReward.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerReward.API.Controllers
{
    
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly IRewardRepo _rewardRepo;
        public RewardsController(IRewardRepo rewardRepo)
        {
            _rewardRepo = rewardRepo;
        }

        // GET: api/<RewardsController>
        [HttpGet("api/v1/reward/{customerId}")]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(long customerId)
        {
            return Ok(new { data = await _rewardRepo.GetRewardsByCustomerId(customerId) }); ;
        }

     

    }
}
