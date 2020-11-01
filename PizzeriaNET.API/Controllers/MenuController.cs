using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzeriaNET.API.Database;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaNET.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IDatabaseHelper _databaseHelper;

        public MenuController(ILogger<MenuController> logger, IDatabaseHelper databaseHelper)
        {
            _logger = logger;
            _databaseHelper = databaseHelper;
        }
        [HttpGet]
        public async Task<ActionResult> GetMenuItems()
        {
            _logger.LogInformation("GetMenuItems Request");
            var menuItems = await _databaseHelper.GetMenuItems();
            if (menuItems is null || !menuItems.Any()) return StatusCode(500);
            return Ok(menuItems);
        }
    }
}
