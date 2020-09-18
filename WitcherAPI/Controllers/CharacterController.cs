using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherAPI.Classes;
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

        // GET: /Character
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters([FromQuery] CharacterQueryParameters queryParameters)
        {
            IQueryable<Character> characters = _context.Characters;

            // filter character based on the name
            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                characters = characters.Where(
                    c => c.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            // filter character based on the eyecolor
            if(!string.IsNullOrEmpty(queryParameters.EyeColor))
            {
                characters = characters.Where(
                    c => c.EyeColor == queryParameters.EyeColor);
            }

            // filter character based on the haircolor
            if(!string.IsNullOrEmpty(queryParameters.HairColor))
            {
                characters = characters.Where(
                    c => c.HairColor == queryParameters.HairColor);
            }

            // filter character based on the gender
            if(!string.IsNullOrEmpty(queryParameters.Gender))
            {
                characters = characters.Where(
                    c => c.Gender == queryParameters.Gender);
            }

                        // sorting the results
                        if(!string.IsNullOrEmpty(queryParameters.SortBy))
                        {
                            if(typeof(Character).GetProperty(queryParameters.SortBy) != null)
                            {
                                characters = characters.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                            }
                        }
            /*
            // pagination
            characters = characters
                .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size);
*/
            return Ok(await characters.ToArrayAsync());
        }

        // GET: /Character/5
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
