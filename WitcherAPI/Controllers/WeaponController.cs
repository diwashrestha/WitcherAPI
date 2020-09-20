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

        // GET: /Weapon
        [HttpGet]
        public async Task<IActionResult> GetAllWeapons([FromQuery] WeaponQueryParameters queryParameters)
        {
            IQueryable<Weapon> weapons = _context.Weapons;

            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                weapons = weapons.Where(
                    w => w.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            if(!string.IsNullOrEmpty(queryParameters.Type))
            {
                weapons = weapons.Where(
                    w => w.Type == queryParameters.Type);
            }

            if(!string.IsNullOrEmpty(queryParameters.Category))
            {
                weapons = weapons.Where(
                    w => w.Category == queryParameters.Category);
            }

            if(queryParameters.Page <= 0)
            {
                weapons = weapons
                    .Skip(0).Take(15);
            }
            else
            {
                // using pagination
                weapons = weapons
                    .Skip(queryParameters.Size * (queryParameters.Page - 1))
                    .Take(queryParameters.Size);
            }

            return Ok(await weapons.ToArrayAsync());
        }



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
