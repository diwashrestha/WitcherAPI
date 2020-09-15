using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherAPI.Models;


// Controller for the characters
namespace WitcherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly WitcherDbContext _context;

        public CharacterController(WitcherDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: /Characters
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters()
        {
            IQueryable<Character> characters = _context.Characters;
            return Ok(await characters.ToArrayAsync());
        }

        // GET: /Characters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }
    }
}
