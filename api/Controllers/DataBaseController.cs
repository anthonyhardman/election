using election.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace election.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        private readonly InstantRunoffContext _instantRunoffContext;

        public DataBaseController(InstantRunoffContext instantRunoffContext)
        {
            this._instantRunoffContext = instantRunoffContext;
        }

        [HttpGet("[action]")]
        public async Task<int> RowCount()
        {
            var rowCount = await _instantRunoffContext.BallotPrefs.CountAsync();
            return rowCount;
        }
    }
}
