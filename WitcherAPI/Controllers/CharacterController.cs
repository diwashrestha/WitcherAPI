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


        /// <summary>
        /// Get all characters
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        // GET: /Character
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters([FromQuery] CharacterQueryParameters queryParameters)
        {
            IQueryable<Character> characters = _context.Characters;


            if(!string.IsNullOrEmpty(queryParameters.Gender))
            {
                characters = characters.Where(c => c.Gender == queryParameters.Gender);
            }


            if(!string.IsNullOrEmpty(queryParameters.Race))
            {
                characters = characters.Where(c => c.Race == queryParameters.Race);
            }

            if(!string.IsNullOrEmpty(queryParameters.Name))
            {
                characters = characters.Where(
                    c => c.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            if(!string.IsNullOrEmpty(queryParameters.EyeColor))
            {
                characters = characters.Where(c => c.EyeColor == queryParameters.EyeColor);
            }

            if(!string.IsNullOrEmpty(queryParameters.HairColor))
            {
                characters = characters.Where(c => c.HairColor == queryParameters.HairColor);
            }


            // when page is not set it takes negative value which will give error
            // So,when page is negative , send 15 characters
            if(queryParameters.Page >0)
            {
                // using pagination
                characters = characters
                    .Skip(queryParameters.Size * (queryParameters.Page - 1))
                    .Take(queryParameters.Size);

            }

            return Ok(await characters.ToArrayAsync());
        }

        /// <summary>
        /// Get a Character using  id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
