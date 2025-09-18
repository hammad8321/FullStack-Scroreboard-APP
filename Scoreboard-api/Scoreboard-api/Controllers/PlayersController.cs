using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoreboard_api.Data;
using Scoreboard_api.Models;

namespace Scoreboard_api.Controllers
{
    [ApiController]
    [Route("api/Players")]
    public class PlayersController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PlayersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetAll()
        {
            return await _context.PlayersDB.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Player>> Create(Player player)
        {
            _context.PlayersDB.Add(player);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = player.Id }, player);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Player updatedPlayer)
        {
            if (id != updatedPlayer.Id) return BadRequest();
            _context.Entry(updatedPlayer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var player = await _context.PlayersDB.FindAsync(id);
            if (player == null) return NotFound();
            _context.PlayersDB.Remove(player);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
