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


            if(queryParameters.Page <= 0)
            {
                armors = armors
                    .Skip(0).Take(15);
            }
            else
            {
                armors = armors
                    .Skip(queryParameters.Size * (queryParameters.Page - 1))
                    .Take(queryParameters.Size);
            }
            return Ok(await armors.ToArrayAsync());
        }


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
