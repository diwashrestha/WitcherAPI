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
    public class MonsterController : ControllerBase
    {
        private readonly WitcherDbContext _context;

        public MonsterController(WitcherDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        /// <summary>
        /// Get all Monsters
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        // GET: /Monster
        [HttpGet]
        public  async Task<IActionResult> GetAllMonsters([FromQuery] MonsterQueryParameters queryParameters)
        {
            IQueryable<Monster> monsters = _context.Monsters;

            if(!string.IsNullOrEmpty(queryParameters.Class))
            {
                monsters = monsters.Where(m => m.Class == queryParameters.Class);
            }

            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                monsters = monsters.Where(
                    m => m.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            if(!string.IsNullOrEmpty(queryParameters.Occurrence))
            {
                monsters = monsters.Where(
                    m => m.Occurrence.ToLower().Contains(queryParameters.Occurrence.ToLower()));
            }

            if(!string.IsNullOrEmpty(queryParameters.VulnerableTo))
            {
                monsters = monsters.Where(
                    m => m.VulnerableTo.ToLower().Contains(queryParameters.VulnerableTo.ToLower()));
            }


            if(queryParameters.Page > 0)
            {
                // using pagination
                monsters = monsters
                    .Skip(queryParameters.Size * (queryParameters.Page - 1))
                    .Take(queryParameters.Size);

            }

            return Ok(await monsters.ToArrayAsync());
        }

        /// <summary>
        /// Get a Monster using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: /Monster/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Monster>> GetMonster(int id)
        {
            var monster = await _context.Monsters.FindAsync(id);

            if(monster == null)
            {
                return NotFound();
            }

            return monster;
        }
    }

}
