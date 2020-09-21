using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherAPI.Classes;
using WitcherAPI.Models;

namespace WitcherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        private readonly WitcherDbContext _context;

        public WeaponController(WitcherDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        /// <summary>
        /// Get all weapons
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        // GET: /Weapon
        [HttpGet]
        public async Task<IActionResult> GetAllWeapons([FromQuery] WeaponQueryParameters queryParameters)
        {
            IQueryable<Weapon> weapons = _context.Weapons;

            // search by name
            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                weapons = weapons.Where(
                    w => w.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            // filter by Type of weapons
            if(!string.IsNullOrEmpty(queryParameters.Type))
            {
                weapons = weapons.Where(
                    w => w.Type == queryParameters.Type);
            }

            // filter by category
            if(!string.IsNullOrEmpty(queryParameters.Category))
            {
                weapons = weapons.Where(
                    w => w.Category == queryParameters.Category);
            }


            if(!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if(typeof(Weapon).GetProperty(queryParameters.SortBy)!= null)
                {
                    weapons = weapons.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                }
            }

            if(queryParameters.Page > 0)
            {
                // using pagination
                weapons = weapons
                    .Skip(queryParameters.Size * (queryParameters.Page - 1))
                    .Take(queryParameters.Size);
            }

            return Ok(await weapons.ToArrayAsync());
        }


        /// <summary>
        /// Get a Weapon using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Weapon/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);

            if(weapon == null)
            {
                return NotFound();
            }
            return weapon;
        }
    }
}
