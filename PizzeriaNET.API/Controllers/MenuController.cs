using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PizzeriaNET.API.Database;

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
            return Ok(menuItems);
        }
    }
}
