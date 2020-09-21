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
    public class ArmorController : ControllerBase
    {
        private readonly WitcherDbContext _context;

        public ArmorController(WitcherDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        /// <summary>
        /// Get all Armor
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>

        // GET: / Armor
        [HttpGet]
        public async Task<IActionResult> GetAllArmors([FromQuery] ArmorQueryParameters queryParameters)
        {
            IQueryable<Armor> armors = _context.Armors;

            if(!string.IsNullOrEmpty(queryParameters.Type))
            {
                armors = armors.Where(a => a.Type == queryParameters.Type);
            }

            if(!string.IsNullOrEmpty(queryParameters.Category))
            {
                armors = armors.Where(a => a.Category == queryParameters.Category);
            }

            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                armors = armors.Where(
                    a => a.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            if(!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if(typeof(Armor).GetProperty(queryParameters.SortBy)!= null)
                {
                    armors = armors.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                }
            }

            if(queryParameters.Page > 0)
            {
                armors = armors
                    .Skip(queryParameters.Size * (queryParameters.Page - 1))
                    .Take(queryParameters.Size);

            }

            return Ok(await armors.ToArrayAsync());
        }


        /// <summary>
        /// Get a Armor data using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: /Armor/4
        [HttpGet("{id}")]
        public async Task<ActionResult<Armor>> GetArmor(int id)
        {
            var armor = await _context.Armors.FindAsync(id);

            if(armor == null)
            {
                return NotFound();
            }

            return armor;
        }
    }
}
